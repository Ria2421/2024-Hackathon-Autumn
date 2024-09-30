using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

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

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if(collision.gameObject.name == "Player")
        {
            hitEffect(collision.gameObject);
            Destroy(this.gameObject);

            Shield shield = GameObject.FindWithTag("Shield").GetComponent<Shield>(); 
            shield.Score = (shield.Score -=50);

            Main main = GameObject.FindWithTag("Manager").GetComponent<Main>();
            main.score.text = shield.Score.ToString();
        }
    }

    /// <summary>
    /// Hit's Effect Progress
    /// </summary>
    async void hitEffect(GameObject gameObject)
    {
        for (int i = 0; i < 5; i++)
        {
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 0);
            await Task.Delay(10);
            gameObject.GetComponent<Renderer>().material.color = new Color32(255, 255, 255, 255);
            await Task.Delay(10);
        }
    }
}
