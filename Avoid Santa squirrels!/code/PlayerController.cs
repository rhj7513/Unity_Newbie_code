using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
    private static PlayerController _instance;
    public static PlayerController Instance
    {
        get
        {
            if(_instance == null)
            {
                _instance = FindObjectOfType<PlayerController>();
            }
            return _instance;
        }
    }
    bool leftFlag = false;//������ȯ�� ���� ����������(�Һ���)
    private int score;//����

    [SerializeField]
    private Text scoreTxt;

    public void Score()
    {
        score++;//����+1��
        scoreTxt.text = "Score : " + score;
        Debug.Log("score:" + score);
    }

    private void FixedUpdate()
    {
      
        if (Input.GetKey(KeyCode.LeftArrow))//���� Ű���� �Է� �ޱ�
        {
            transform.Translate(-0.3f, 0, 0);//�������� 0.1�̵�
            leftFlag = true;//�� �Ǵ� ���� ���� �����ϴ� ��
        }
        if (Input.GetKey(KeyCode.RightArrow))//������ Ű���� �Է� �ޱ�
        {
            transform.Translate(0.3f, 0, 0);//���������� 0.1�̵�
            leftFlag = false;
        }
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
    
}
