using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float targetTime;
    [SerializeField] GameObject bullet;
    [SerializeField] private float moveSpeed;
    private Rigidbody2D rb;
    float currentTime = 0;
    GameObject player;
    Vector3 dir;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Player");
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        switch (this.gameObject.name)
        {
            case "canon":
                currentTime += Time.deltaTime;
                if (Random.Range(targetTime, targetTime + 2.0f) < currentTime)
                {
                    Instantiate(bullet, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                    currentTime = 0;
                }
                break;
            case "enemy":

                Vector2 vec = player.transform.position - this.gameObject.transform.position;
                this.rb.velocity = vec.normalized * Random.Range(moveSpeed, moveSpeed + 1.5f);

                // 向きたい方向を計算
                dir = (player.transform.position - this.gameObject.transform.position);

                // ここで向きたい方向に回転させてます
                this.gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);

                break;
            case "gunner":
                currentTime += Time.deltaTime;
                if (Random.Range(targetTime, targetTime + 2.0f) < currentTime)
                {
                    GameObject obj = Instantiate(bullet, new Vector2(this.transform.position.x, this.transform.position.y), Quaternion.identity);
                    obj.GetComponent<Renderer>().material.color = Color.yellow;
                    currentTime = 0;
                }

                // 向きたい方向を計算
                dir = (player.transform.position - this.gameObject.transform.position);

                // ここで向きたい方向に回転させてます
                this.gameObject.transform.rotation = Quaternion.FromToRotation(Vector3.up, dir);
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if ((collision.gameObject.name == "Player" || collision.gameObject.name == "Shield") && this.gameObject.name == "enemy")
        {
            Destroy(this.gameObject);
        }
    }
}
