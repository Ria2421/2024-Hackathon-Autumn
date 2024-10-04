using KanKikuchi.AudioManager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        BGMSwitcher.FadeOutAndFadeIn(BGMPath.IN_GAME);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
