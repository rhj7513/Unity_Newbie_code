using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//1�ʿ� 60~80 ���� ������
    {
        
    }
    void FixedUpdate()//1�ʿ� 50�� ���� ������
    {
        this.transform.Translate(0.1f, 0, 0);
    }
}
