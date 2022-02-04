using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    //OnTriggerEnter2D함수는 Star,Update와 같이 "유니티에 내장된 함수"이다.
    //유니티에서 "트리거가 활성화되었을 때" 실행하는 함수이다.
    // 트리거 활성 -> player 오브젝트가 Is Trigger에 체크가 되어있는 다른 물체에 충돌했다는 것을 말한다.
    {
        if (collision.CompareTag("장애물")) //CompareTag는 태그를 확인하는 함수 -> 장애물태그만 해당
        {
            player();//함수 호출
            SceneManager.LoadScene("GameOver");//Scene변경(GameOver)
        }
        else if (collision.CompareTag("성공"))//-> 성공태그만 해당
        {
            player();//함수 호출
            SceneManager.LoadScene("GameWin");//Scene변경(GameWin)
        }

    }

    public void player()//함수 추가
    {
        Destroy(gameObject);//Destroy는 괄호 안에 들어가있는 오브젝트를 파괴하는 명령어
        //gameObject는 "나 자신"을 말한다. -> player 오브젝트 사라짐
    }
}
