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
            /* �t�F�[�h���� (��)  
                ( "�V�[����",�t�F�[�h�̐F, ����);  */
            Initiate.DoneFading();
            Initiate.Fade("Tutorial", Color.white, 2.5f);
        }
    }
}
