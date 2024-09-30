using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            /* フェード処理 (白)  
                ( "シーン名",フェードの色, 速さ);  */
            Initiate.DoneFading();
            Initiate.Fade("Main", Color.white, 2.5f);
        }
    }
}
