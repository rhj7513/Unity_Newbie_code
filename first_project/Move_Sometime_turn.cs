using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sometime_turn : MonoBehaviour
{
    public float angle = 90.0f;//초기 각도값
    public float maxCount = 50.0f;//초기 빈도
    int count = 0;//카운터용

    public float speed = 1.0f; //속도값 <- 이 변수는 버플릭변수이기 때문에 인스펙터에서 변경이 가능하다.

    // Start is called before the first frame update
    void Start()
    {
        count = 0;//카운터를 리셋
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1; //0+1

        this.transform.Translate(speed / 50, 0, 0);//수평이동(+x축방향으로 이동)
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle);//Rotate(x,y,z)
            count = 0;
        }


    }
}
