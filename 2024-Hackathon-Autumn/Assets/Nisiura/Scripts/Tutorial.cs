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
            /* �t�F�[�h���� (��)  
                ( "�V�[����",�t�F�[�h�̐F, ����);  */
            Initiate.DoneFading();
            Initiate.Fade("Main", Color.white, 2.5f);
        }
    }
}
