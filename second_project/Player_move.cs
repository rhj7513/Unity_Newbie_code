using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float mvoe_Speed = 1.0f;//속도 초기값(변수)
    float x_Speed = 0;//x축방향 속도(변수)
    float y_Speed = 0;//y축방향 속도(변수)
    bool leftFlag = false;//방향전환을 위한 참거짓변수(불변수)

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x_Speed = 0;
        y_Speed = 0;

        if (Input.GetKey("right"))
        {
            x_Speed = mvoe_Speed;
            leftFlag = false;//참 또는 거짓 값을 대입하는 것
            //this.transform.Translate(x_Speed, 0, 0);
        }
        else if (Input.GetKey("left"))
        {
            x_Speed = -mvoe_Speed;
            leftFlag = true;
            //this.transform.Translate(-x_Speed, 0, 0);
        }
        else if (Input.GetKey("up"))
        {
            y_Speed = mvoe_Speed;
            //this.transform.Translate(0, y_Speed, 0);
        }
        else if (Input.GetKey("down"))
        {
            y_Speed = -mvoe_Speed;
            //this.transform.Translate(0, -y_Speed, 0);
        }
    }
    private void FixedUpdate()//매초마다 동일한 프레임
    {
        this.transform.Translate(x_Speed, y_Speed, 0);//오, 왼, 위, 아래 오브젝트 이동
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        //오른쪽, 왼쪽 방향으로 이동시 스프라이트 방향 전환
    }
}
