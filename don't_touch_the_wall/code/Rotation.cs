using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotSpeed = 5;// 속도 초기값(변수)
    float rot_Z = 0;//z축값 (변수)
    void Update()
    {
        rot_Z = rotSpeed;//z축에 속도 변수 넣기
        transform.Rotate(0, 0, rot_Z);
    }
}
