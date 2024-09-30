using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    public float currentTime = 0;
    float targetTime = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (targetTime < currentTime)
        {
            Instantiate(bullet, new Vector2(this.transform.position.x , this.transform.position.y), Quaternion.identity);
            currentTime = 0;
        }
    }
}
