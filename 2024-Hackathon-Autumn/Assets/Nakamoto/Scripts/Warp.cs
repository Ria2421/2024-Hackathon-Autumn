//---------------------------------------------------------------
//
// ワープスクリプト [ Warp.cs ]
// Author:Kenta Nakamoto
// Data:2024/09/30
//
//---------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    [SerializeField] private GameObject warpObj;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.transform.position = warpObj.transform.position;
        }
    }
}
