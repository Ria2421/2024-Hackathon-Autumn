using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TestManager : MonoBehaviour
{
    static public int score { get; set; }
    RankingManager rankingManager;

    // Start is called before the first frame update
    void Start()
    {
        rankingManager = new RankingManager();
        //ここに入力した値がランキングに反映
        score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            SceneManager.LoadScene("Ranking");
        }
    }
}
