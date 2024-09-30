using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleManager : MonoBehaviour
{
    bool pushFlag = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKey)
        {
            /* フェード処理 (白)  
                ( "シーン名",フェードの色, 速さ);  */
            Initiate.DoneFading();
            Initiate.Fade("Tutorial", Color.white, 2.5f);
        }
    }
}
