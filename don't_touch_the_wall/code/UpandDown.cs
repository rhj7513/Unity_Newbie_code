using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpandDown : MonoBehaviour
{
    Vector3 pos; //현재위치
    float delta = 2.0f; // 위(아래)로 이동가능한 (y)최대값
    public float speed = 3.0f; // 이동속도

    void Start()
    {
        pos = transform.position;
    }


    void Update()
    {
        Vector3 v = pos;
        v.y += delta * Mathf.Sin(Time.time * speed);
        // 좌우 이동의 최대치 및 반전 처리
        transform.position = v;
    }
}
