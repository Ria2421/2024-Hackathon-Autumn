//=================================================
//ランキング処理
//参考1　https://qiita.com/tilyakuda/items/4999bfcfad97dea3d0e8
//参考2　https://qiita.com/tilyakuda/items/e3ccfbf507acfb16404f
//三宅歩人
//=================================================
using KanKikuchi.AudioManager;
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
        point = Shield.score;
    }

    void Start()
    {
        BGMSwitcher.FadeOutAndFadeIn(BGMPath.TITLEMOROMORO);

        GetRanking();
        SetRanking(point);
        for (int i = 0; i < rankingText.Length; i++)
        {
            rankingText[i].text = rankingValue[i].ToString();
        }

        //ランキングデータ削除
        //PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Return))
        {
            /* フェード処理 (白)  
                ( "シーン名",フェードの色, 速さ);  */
            Initiate.DoneFading();
            Initiate.Fade("DemoScene", Color.white, 2.5f);
        }
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
