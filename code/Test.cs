using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour//클래스 이름은 스크립트 파일이름가 같아야 합니다.
{
    // Start is called before the first frame update
    void Start()//매번 프레임이 갱신되어도 스타트 메소드 안에 있는 내용은 한번만 실행한다.
    {
        this.transform.Translate(10.0f, 0, 0);//이 스크립트가 속해 있는 게임오브젝트를 이동시킨다. Translate(x,y,z)함수 사용
    }

    // Update is called once per frame
    void Update()//매 프레임마다 계속적으로 갱신(추가)가 되는 메소드 50~80 계속적으로 실행한다.(FixedUpdate 50~60)
    {
        
    }
}
