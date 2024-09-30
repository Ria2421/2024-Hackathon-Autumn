using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int Score = 0;
    private Main manager;

    // Start is called before the first frame update
    void Start()
    {
        manager = GameObject.Find("Manager").GetComponent<Main>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /// <summary>
    /// ÉVÅ[ÉãÉhÇ≈ÇÃñhå‰èàóù
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (manager.ClearFlag) return;

        Destroy(collision.gameObject);
        Score += 100;
        Main main = GameObject.FindWithTag("Manager").GetComponent<Main>();
        main.score.text = Score.ToString();
    }
}
