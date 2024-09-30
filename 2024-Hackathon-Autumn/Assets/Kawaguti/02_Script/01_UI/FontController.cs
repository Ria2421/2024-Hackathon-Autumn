using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FontController : MonoBehaviour
{
    [SerializeField] Text itemName;

    private float _repeatSpan;    //�J��Ԃ��Ԋu
    private float _rag;    //�J��Ԃ��Ԋu
    private float _timeElapsed;   //�o�ߎ���

    // Start is called before the first frame update
    void Start()
    {
        //�\���؂�ւ����Ԃ��w��
        _repeatSpan = 0.06f;
        _timeElapsed = 0;

        _rag = 0.06f;
    }

    // Update is called once per frame
    void Update()
    {
        _timeElapsed += Time.deltaTime;     //���Ԃ��J�E���g����

        if (_timeElapsed >= _repeatSpan)
        {//���Ԍo�߂Ńe�L�X�g�\��
            Font font = Resources.Load<Font>("Font/Grid/Grid1");
            itemName.font = font;
        }
        if (_timeElapsed >= _repeatSpan + _rag)
        {//���Ԍo�߂Ńe�L�X�g�\��(��E)
            Font font = Resources.Load<Font>("Font/Grid/Grid2");
            itemName.font = font;
        }
        if (_timeElapsed >= _repeatSpan + _rag * 2)
        {//���Ԍo�߂Ńe�L�X�g�\��(��E)
            Font font = Resources.Load<Font>("Font/Grid/Grid3");
            itemName.font = font;
        }
        if (_timeElapsed >= _repeatSpan + _rag * 3)
        {//���Ԍo�߂Ńe�L�X�g�\��(��E)
            Font font = Resources.Load<Font>("Font/Grid/Grid2");
            itemName.font = font;
            _timeElapsed = 0;   //�o�ߎ��Ԃ����Z�b�g����
        }

    }
    
}
