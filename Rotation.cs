using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    public float rotSpeed = 5;// �ӵ� �ʱⰪ(����)
    float rot_Z = 0;//z�ప (����)
    void Update()
    {
        rot_Z = rotSpeed;//z�࿡ �ӵ� ���� �ֱ�
        transform.Rotate(0, 0, rot_Z);
    }
}
