using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour//Ŭ���� �̸��� ��ũ��Ʈ �����̸��� ���ƾ� �մϴ�.
{
    // Start is called before the first frame update
    void Start()//�Ź� �������� ���ŵǾ ��ŸƮ �޼ҵ� �ȿ� �ִ� ������ �ѹ��� �����Ѵ�.
    {
        this.transform.Translate(10.0f, 0, 0);//�� ��ũ��Ʈ�� ���� �ִ� ���ӿ�����Ʈ�� �̵���Ų��. Translate(x,y,z)�Լ� ���
    }

    // Update is called once per frame
    void Update()//�� �����Ӹ��� ��������� ����(�߰�)�� �Ǵ� �޼ҵ� 50~80 ��������� �����Ѵ�.(FixedUpdate 50~60)
    {
        
    }
}
