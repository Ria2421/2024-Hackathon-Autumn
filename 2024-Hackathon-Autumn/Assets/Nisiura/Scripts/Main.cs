using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // ステージのゲームオブジェクト
    [SerializeField] GameObject Stage;

    // シールドのゲームオブジェクト
    [SerializeField] GameObject Shield;

    // 回転速度
    public float Speed = 3f;
    public Text score;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiltStage();
    }

    /// <summary>
    /// 回転処理
    /// </summary>
    void TiltStage()
    {
        // 右矢印を押した際、シールドとステージを右回転
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Stage.transform.Rotate(0f, 0f, -Speed);
            Shield.transform.Rotate(0f, 0f, Speed *1.5f);
        }

        // 左矢印を押した際、シールドとステージを左回転
        if (Input.GetKey(KeyCode.LeftArrow))
        {   
            Stage.transform.Rotate(0f, 0f, Speed);
            Shield.transform.Rotate(0f, 0f, -Speed *1.5f);
        }
    }

}
