//---------------------------------------------------------------
//
// スプリングスクリプト [ Spring.cs ]
// Author:Kenta Nakamoto
// Data:2024/09/30
//
//---------------------------------------------------------------
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spring : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            collision.rigidbody.AddForce(new Vector3(0,35f));
        }
    }
}
