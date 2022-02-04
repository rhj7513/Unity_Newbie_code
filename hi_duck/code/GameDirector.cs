using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI를 쓸ㄸ는 꼭 사용해야 함.

public class GameDirector : MonoBehaviour
{
    GameObject player;//플레이어 오브젝트를 대입할 변수 (데이터형: GameObject)
    GameObject duck;//목표물 오브젝트를 대입할 변수 (데이터형:GameObject)
    GameObject distance;//플레이어 오브젝트와 목표물 오브젝트 사이의 거리를 표시할 UI오브젝트를 대입할 변수
    GameObject distance2;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.duck = GameObject.Find("숨었당");
        this.distance = GameObject.Find("이동거리");
        this.distance2 = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.duck.transform.position.x - this.player.transform.position.x;
       
       if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "Goals" + ":" + lengthDis.ToString("F5") + "m";
            this.distance2.GetComponent<Text>().text = "Let's go all the way to duck forest.";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!";
            this.distance2.GetComponent<Text>().text = "great!!.";
        }
        //ToString("D숫자")정수형, 숫자는 자리수 D4는 1000자리까지 표시
        //ToString("F숫자")소수점 이하 소수까지 표시
    }
}
