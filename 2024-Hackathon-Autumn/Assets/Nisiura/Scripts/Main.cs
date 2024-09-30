using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Main : MonoBehaviour
{
    [SerializeField] GameObject Stage;

    [SerializeField] GameObject Shield;

    float Speed = 0.8f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TiltStage();
    }

    void TiltStage()
    {
        // ‰E–îˆó‚ğ‰Ÿ‚µ‚½Û
        if (Input.GetKey(KeyCode.RightArrow))
        {
            Stage.transform.Rotate(0f, 0f, -Speed);
            Shield.transform.Rotate(0f, 0f, Speed);
        }

        // ¶–îˆó‚ğ‰Ÿ‚µ‚½Û
        if (Input.GetKey(KeyCode.LeftArrow))
        {   
            Stage.transform.Rotate(0f, 0f, Speed);
            Shield.transform.Rotate(0f, 0f, -Speed);
        }
    }

}
