//=================================================
//�����L���O����
//�Q�l1�@https://qiita.com/tilyakuda/items/4999bfcfad97dea3d0e8
//�Q�l2�@https://qiita.com/tilyakuda/items/e3ccfbf507acfb16404f
//�O����l
//=================================================
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RankingManager : MonoBehaviour
{
    //���l
    [SerializeField, Header("���l")]
    public int point;
    //�e�L�X�g
    [SerializeField, Header("�\��������e�L�X�g")]
    Text[] rankingText = new Text[5];

    /// <summary>
    /// �ϐ�
    /// </summary>
    //�����L���O�̔z��
    string[] ranking = { "No.1", "No.2", "No.3", "No.4", "No.5" };
    //�����L���O�̐�
    int[] rankingValue = new int[5];

    private void Awake()
    {
        //�X�R�A�������ė���
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

        //�����L���O�f�[�^�폜
        //PlayerPrefs.DeleteAll();
    }

    /// <summary>
    /// �����L���O�Ăяo��
    /// </summary>
    void GetRanking()
    {
        //�����L���O�Ăяo��
        for (int i = 0; i < ranking.Length; i++)
        {
            rankingValue[i] = PlayerPrefs.GetInt(ranking[i]);
        }
    }

    /// <summary>
    /// �����L���O��������
    /// </summary>
    public void SetRanking(int value)
    {
        //�������ݗp
        for (int i = 0; i < ranking.Length; i++)
        {
            //�擾�����l��Ranking�̒l���r���ē���ւ�
            if (value > rankingValue[i])
            {
                var change = rankingValue[i];
                rankingValue[i] = value;
                value = change;
            }
        }

        //����ւ����l��ۑ�
        for (int i = 0; i < ranking.Length; i++)
        {
            PlayerPrefs.SetInt(ranking[i], rankingValue[i]);
        }
    }
}
