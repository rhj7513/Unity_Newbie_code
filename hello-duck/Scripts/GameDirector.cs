using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�� ������ �� ����ؾ� ��.

public class GameDirector : MonoBehaviour
{
    GameObject player;//�÷��̾� ������Ʈ�� ������ ���� (��������: GameObject)
    GameObject duck;//��ǥ�� ������Ʈ�� ������ ���� (��������:GameObject)
    GameObject distance;//�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI������Ʈ�� ������ ����
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("���ٵ�");
        this.duck = GameObject.Find("������");
        this.distance = GameObject.Find("�̵��Ÿ�");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.duck.transform.position.x - this.player.transform.position.x;
        if(lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "��ǥ����" + ":" + lengthDis.ToString("F5") + "m";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!";
        }
        //ToString("D����")������, ���ڴ� �ڸ��� D4�� 1000�ڸ����� ǥ��
        //ToString("F����")�Ҽ��� ���� �Ҽ����� ǥ��
    }
}
