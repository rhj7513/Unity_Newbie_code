using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveH : MonoBehaviour
{
    public float speed = 1.0f; //�ӵ��� <- �� ������ ���ø������̱� ������ �ν����Ϳ��� ������ �����ϴ�.

    void FixedUpdate()//�� �����Ӹ��� ��� �����Ѵ�.(Update), �����ð����� ��� �����Ѵ�.(FixedUpdate)
    {
        this.transform.Translate(speed / 50, 0, 0);//�����̵�(+x��������� �̵�)
    }
}
