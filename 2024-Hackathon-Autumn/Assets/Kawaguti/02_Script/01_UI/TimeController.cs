
using System.Collections.Generic;
using UnityEngine;
// 追加
using UnityEngine.UI;
 
public class TimeController : MonoBehaviour
{
    public Text timeLabel;
    float timeCount = 30.0f;

    //private float timeCount = 0;
    double _playTimeSec;

    void Start()
    {
        // 小数点２位まで表示
        timeLabel.text = timeCount.ToString("n2");
    }

    void Update()
    {
       timeCount -= Time.deltaTime;

        if (timeCount <= 0.0f)
        {
            GameObject.Find("Manager").GetComponent<Main>().ClearFlag = true;

            /* フェード処理 (白)  
                ( "シーン名",フェードの色, 速さ);  */
            Initiate.DoneFading();
            Initiate.Fade("Ranking", Color.white, 2.5f);
        }

        timeLabel.text = timeCount.ToString("n2");

       

        /*timeLabel.text = string.Format("[Play Time]\n{0:00}:{1:00}",
          
           (int)_playTimeSec / 60 % 60, // 分
           (int)_playTimeSec % 60); // 秒

        _playTimeSec += Time.deltaTime;*/
    }
}