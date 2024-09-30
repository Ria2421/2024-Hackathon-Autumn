
using System.Collections.Generic;
using UnityEngine;
// í«â¡
using UnityEngine.UI;
 
public class TimeController : MonoBehaviour
{
    public Text timeLabel;
    [SerializeField] float timeCount;

    //private float timeCount = 0;
    double _playTimeSec;

    void Start()
    {
        // è¨êîì_ÇQà Ç‹Ç≈ï\é¶
        timeLabel.text = timeCount.ToString("n2");
    }

    void Update()
    {
       timeCount -= Time.deltaTime;

        if (timeCount <= 0.0f) return;

         timeLabel.text = timeCount.ToString("n2");

       

        /*timeLabel.text = string.Format("[Play Time]\n{0:00}:{1:00}",
          
           (int)_playTimeSec / 60 % 60, // ï™
           (int)_playTimeSec % 60); // ïb

        _playTimeSec += Time.deltaTime;*/
    }
}