//=================================================
//ランキング処理
//参考1　https://qiita.com/tilyakuda/items/4999bfcfad97dea3d0e8
//参考2　https://qiita.com/tilyakuda/items/e3ccfbf507acfb16404f
//三宅歩人
//=================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingManager : MonoBehaviour
{
    //数値
    [SerializeField, Header("数値")]
    public int point;
    //テキスト
    [SerializeField, Header("表示させるテキスト")]
    Text[] rankingText = new Text[5];

    /// <summary>
    /// 変数
    /// </summary>
    //ランキングの配列
    string[] ranking = { "No.1", "No.2", "No.3", "No.4", "No.5" };
    //ランキングの数
    int[] rankingValue = new int[5];

    private void Awake()
    {
        //スコアを持って来る
        point = TestManager.score;
    }

    void Start()
    {
        GetRanking();
        SetRanking(point);
        for (int i = 0; i < rankingText.Length; i++)
        {
            rankingText[i].text = rankingValue[i].ToString();
        }

        //ランキングデータ削除
        //PlayerPrefs.DeleteAll();
    }

    /// <summary>
    /// ランキング呼び出し
    /// </summary>
    void GetRanking()
    {
        //ランキング呼び出し
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
        }
    }

    /// <summary>
    /// ランキング書き込み
    /// </summary>
    public void SetRanking(int value)
    {
        //書き込み用
        for (int i = 0; i < ranking.Length; i++)
        {
            //取得した値とRankingの値を比較して入れ替え
            if (value > rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = value;
                value = change;
            }
        }

        //入れ替えた値を保存
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
        }
    }
}
