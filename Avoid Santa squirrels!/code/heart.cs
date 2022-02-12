using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heart : MonoBehaviour
{
    GameObject player;//player �������� GameObject�� ������ ���̴�.
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");//�̸��� player�� GameObject�� ���� player�� ����
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -0.1f, 0);//-y��(�Ʒ�����)���� �̵�
        if (transform.position.y < -9.0f)
        {
            Destroy(gameObject);
        }
        Vector2 p1 = transform.position;//�ڽ��� x,y ��ǥ���� ���� p1�� ����
        Vector2 p2 = this.player.transform.position;//player�� x,y��ǥ�� ���� p2�� ����
        Vector2 dir = p1 - p2;//���� dir�� p1-p2 ���� ����
        float d = dir.magnitude;//���� dir�� ���̸� �Ǽ��� ��ȯ
        float r1 = 0.9f;//r1(HPH)�� ������Ʈ�� ������
        float r2 = 1.0f;//r2(player) ������Ʈ�� ������
        float r3 = r1 + r2;
        if (d < r3)
        {
            GameObject director = GameObject.Find("Game2Director");
            director.GetComponent<Game2Director>().IncreaseHP();
            Destroy(gameObject);
        }

    }
}
