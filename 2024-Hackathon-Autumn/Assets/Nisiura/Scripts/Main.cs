using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Main : MonoBehaviour
{
    // �X�e�[�W�̃Q�[���I�u�W�F�N�g
    [SerializeField] GameObject Stage;

    // �V�[���h�̃Q�[���I�u�W�F�N�g
    [SerializeField] GameObject Shield;

    // ��]���x
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
    /// ��]����
    /// </summary>
    void TiltStage()
    {
        // �E�����������ہA�V�[���h�ƃX�e�[�W���E��]
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Stage.transform.Rotate(0f, 0f, -Speed);
            Shield.transform.Rotate(0f, 0f, Speed *1.5f);
        }

        // �������������ہA�V�[���h�ƃX�e�[�W������]
        if (Input.GetKey(KeyCode.LeftArrow))
        {   
            Stage.transform.Rotate(0f, 0f, Speed);
            Shield.transform.Rotate(0f, 0f, -Speed *1.5f);
        }
    }

}
