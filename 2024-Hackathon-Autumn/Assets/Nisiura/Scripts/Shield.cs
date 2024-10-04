using KanKikuchi.AudioManager;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Shield : MonoBehaviour
{
    static public int score;
    private Main manager;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
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
        SEManager.Instance.Play(SEPath.BLOCK);
        if (manager.ClearFlag) return;

        Destroy(collision.gameObject);
        score += 100;
        manager.score.text = score.ToString();
    }
}
