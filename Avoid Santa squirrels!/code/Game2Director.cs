using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2Director : MonoBehaviour
{
    GameObject hpGauge;//Hp�� �޾ƿ� ����(�̹���)
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("Hp");//HP�� ã�ƶ�
    }

    public void IncreaseHP()//Hp���� �Լ��� ����
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;//0.1�� ����
    }
}
