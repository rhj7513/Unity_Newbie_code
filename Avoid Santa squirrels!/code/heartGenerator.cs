using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartGenerator : MonoBehaviour
{
    public GameObject ��������;
    float respan = 1.0f;//���� ������ ��Ÿ���� �ð�(������ �ð�)
    float delta = 0;//������ �ð��� ���ϱ� ���� �ð� ����

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;// this.delta += Time.deltaTime;
        if (this.delta > this.respan)
        {
            this.delta = 0;
            GameObject copyHeart = Instantiate(��������) as GameObject;
            float range = Random.Range(-6.0f, 6.0f);//Random.Range(�ּҰ�, �ִ밪)
            copyHeart.transform.position = new Vector3(range, 10, 0);
        }
    }
}
