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
    bool leftFlag = false;//방향전환을 위한 참거짓변수(불변수)
    private int score;//점수

    [SerializeField]
    private Text scoreTxt;

    public void Score()
    {
        score++;//점수+1점
        scoreTxt.text = "Score : " + score;
        Debug.Log("score:" + score);
    }

    private void FixedUpdate()
    {
      
        if (Input.GetKey(KeyCode.LeftArrow))//왼쪽 키보드 입력 받기
        {
            transform.Translate(-0.3f, 0, 0);//왼쪽으로 0.1이동
            leftFlag = true;//참 또는 거짓 값을 대입하는 것
        }
        if (Input.GetKey(KeyCode.RightArrow))//오른쪽 키보드 입력 받기
        {
            transform.Translate(0.3f, 0, 0);//오른쪽으로 0.1이동
            leftFlag = false;
        }
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
    
}
