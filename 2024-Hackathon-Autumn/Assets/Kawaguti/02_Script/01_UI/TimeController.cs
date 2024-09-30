
using System.Collections.Generic;
using UnityEngine;
// �ǉ�
using UnityEngine.UI;
 
public class TimeController : MonoBehaviour
{
    public Text timeLabel;
    float timeCount = 30.0f;

    //private float timeCount = 0;
    double _playTimeSec;

    void Start()
    {
        // �����_�Q�ʂ܂ŕ\��
        timeLabel.text = timeCount.ToString("n2");
    }

    void Update()
    {
       timeCount -= Time.deltaTime;

        if (timeCount <= 0.0f)
        {
            GameObject.Find("Manager").GetComponent<Main>().ClearFlag = true;

            /* �t�F�[�h���� (��)  
                ( "�V�[����",�t�F�[�h�̐F, ����);  */
            Initiate.DoneFading();
            Initiate.Fade("Ranking", Color.white, 2.5f);
        }

        timeLabel.text = timeCount.ToString("n2");

       

        /*timeLabel.text = string.Format("[Play Time]\n{0:00}:{1:00}",
          
           (int)_playTimeSec / 60 % 60, // ��
           (int)_playTimeSec % 60); // �b

        _playTimeSec += Time.deltaTime;*/
    }
}