using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_Sometime_turn : MonoBehaviour
{
    public float angle = 90.0f;//�ʱ� ������
    public float maxCount = 50.0f;//�ʱ� ��
    int count = 0;//ī���Ϳ�

    public float speed = 1.0f; //�ӵ��� <- �� ������ ���ø������̱� ������ �ν����Ϳ��� ������ �����ϴ�.

    // Start is called before the first frame update
    void Start()
    {
        count = 0;//ī���͸� ����
    }

    // Update is called once per frame
    void Update()
    {
        count = count + 1; //0+1

        this.transform.Translate(speed / 50, 0, 0);//�����̵�(+x��������� �̵�)
        if (count >= maxCount)
        {
            this.transform.Rotate(0, 0, angle);//Rotate(x,y,z)
            count = 0;
        }


    }
}
