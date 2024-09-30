using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {
        
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
        Destroy(collision.gameObject);
        Score += 100;
        Main main = GameObject.FindWithTag("Manager").GetComponent<Main>();
        main.score.text = Score.ToString();
    }
}
