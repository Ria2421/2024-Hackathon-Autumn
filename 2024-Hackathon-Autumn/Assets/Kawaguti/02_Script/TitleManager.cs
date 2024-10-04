using KanKikuchi.AudioManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using KanKikuchi.AudioManager;

public class TitleManager : MonoBehaviour
{
    bool pushFlag = false;

    void Start()
    {
        BGMManager.Instance.Play(BGMPath.TITLEMOROMORO);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }

        if (Input.anyKey)
        {
            /* フェード処理 (白)  
                ( "シーン名",フェードの色, 速さ);  */
            Initiate.DoneFading();
            Initiate.Fade("Tutorial", Color.white, 2.5f);
        }
    }
}
