using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Leftandright : MonoBehaviour
{

    Vector3 pos; //������ġ
    float delta = 2.0f; // ��(��)�� �̵������� (x)�ִ밪
    float speed = 3.0f; // �̵��ӵ�

    void Start()
    {
        pos = transform.position;
    }


    void Update()
    {
        Vector3 v = pos;
        v.x += delta * Mathf.Sin(Time.time * speed);
        // �¿� �̵��� �ִ�ġ �� ���� ó��
        transform.position = v;
    }
}
