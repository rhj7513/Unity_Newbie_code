using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//UI�� ������ �� ����ؾ� ��.

public class GameDirector : MonoBehaviour
{
    GameObject player;//�÷��̾� ������Ʈ�� ������ ���� (��������: GameObject)
    GameObject duck;//��ǥ�� ������Ʈ�� ������ ���� (��������:GameObject)
    GameObject distance;//�÷��̾� ������Ʈ�� ��ǥ�� ������Ʈ ������ �Ÿ��� ǥ���� UI������Ʈ�� ������ ����
    GameObject distance2;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.duck = GameObject.Find("������");
        this.distance = GameObject.Find("�̵��Ÿ�");
        this.distance2 = GameObject.Find("Text");
    }

    // Update is called once per frame
    void Update()
    {
        float lengthDis = this.duck.transform.position.x - this.player.transform.position.x;
       
       if (lengthDis >= 0)
        {
            this.distance.GetComponent<Text>().text = "Goals" + ":" + lengthDis.ToString("F5") + "m";
            this.distance2.GetComponent<Text>().text = "Let's go all the way to duck forest.";
        }
        else
        {
            this.distance.GetComponent<Text>().text = "Game Over!!";
            this.distance2.GetComponent<Text>().text = "great!!.";
        }
        //ToString("D����")������, ���ڴ� �ڸ��� D4�� 1000�ڸ����� ǥ��
        //ToString("F����")�Ҽ��� ���� �Ҽ����� ǥ��
    }
}
