using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float speed = 0;//오브젝트가 이동하기 위해 필요한  변수 선언
    Vector2 startPos;//마우스를 눌렀을 때
    //2차원 좌표의 벡터(x,y) 3차원 좌표의 벡터값(x,y,z)
    //Vecor2는 2차원 좌표값을 갖습니다.(xy) Vector3(x,y,z)
    Vector2 endPos;//마우스를 눌렀다 떼었을 때의 위치값이 들어갈 변수
    public float 분모값 = 1000.0f;//분모값
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//마우스 왼쪽버튼을 누르면
        {
            this.startPos = Input.mousePosition;//마우스버튼으로 눌렀을 때의 위치값(x,y)
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;//마우스 버튼을 눌렀다가 떼었을 때의 위치값(x,y)
            float length = (this.endPos.x - this.startPos.x);//endpos - startpos의 값은 이동속도로 이용할 것 그리고 이 값은 length에 대입한다. length변수는 speed 변수에 대입할 것이다.
            //마지막 좌표값 - 처음 좌표값을 빼줍니다.
            this.speed = length / 분모값;//length값은 speed값에 대입한다. speed값은 Translate x에 대입하여 오브젝트를 이동하게 한다.
            this.GetComponent<AudioSource>().Play();
        }
        //transform.Translate(this.speed* Time.deltaTime, 0, 0);//이동 x+방향
        transform.Translate(this.speed , 0, 0);//이동 x+방향
        this.speed *= 0.98f;//감속








        /*if (Input.GetMouseButton(0))//마우스 왼쪽버튼을 누르면
        {
            this.speed = 0.1f;//처음속도를 설정해서 대입
        }
        if (Input.GetMouseButton(1))//마우스 왼쪽버튼을 누르면
        {
            this.speed = -0.1f;
        }
        transform.Translate(this.speed, this.speed, 0);//이동 x+방향
        this.speed *= 0.98f;//감속*/
    }
}
