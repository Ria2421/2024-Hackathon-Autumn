using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.Find("Player");
        Vector2 vec = player.transform.position - this.gameObject.transform.position;
        rb.velocity = vec.normalized * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
