using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float targetTime;
    [SerializeField] GameObject bullet;
    float currentTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentTime += Time.deltaTime;
        if (Random.Range(targetTime,targetTime + 2.0f) < currentTime)
        {
            Instantiate(bullet, new Vector2(this.transform.position.x , this.transform.position.y), Quaternion.identity);
            currentTime = 0;
        }
    }
}
