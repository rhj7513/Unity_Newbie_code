using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Game2Director : MonoBehaviour
{
    GameObject hpGauge;//Hp를 받아올 변수(이미지)
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("Hp");//HP를 찾아라
    }

    public void IncreaseHP()//Hp증가 함수를 만듬
    {
        this.hpGauge.GetComponent<Image>().fillAmount += 0.1f;//0.1씩 증가
    }
}
