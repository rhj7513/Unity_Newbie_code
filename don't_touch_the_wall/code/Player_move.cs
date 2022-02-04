using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_move : MonoBehaviour
{
    public float mvoe_Speed = 1.0f;//�ӵ� �ʱⰪ(����)
    float x_Speed = 0;//x����� �ӵ�(����)
    float y_Speed = 0;//y����� �ӵ�(����)
    bool leftFlag = false;//������ȯ�� ���� ����������(�Һ���)

    // Update is called once per frame
    void Update()
    {
        x_Speed = 0;
        y_Speed = 0;

        if (Input.GetKey("right"))
        {
            x_Speed = mvoe_Speed;
            leftFlag = false;//�� �Ǵ� ���� ���� �����ϴ� ��
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
    private void FixedUpdate()//���ʸ��� ������ ������
    {
        this.transform.Translate(x_Speed, y_Speed, 0);//��, ��, ��, �Ʒ� ������Ʈ �̵�
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
        //������, ���� �������� �̵��� ��������Ʈ ���� ��ȯ
    }
}
