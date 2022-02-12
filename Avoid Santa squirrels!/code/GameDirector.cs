using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameDirector : MonoBehaviour
{
    /*public AudioClip audioAttack;
    AudioSource audioSource;

    void Awake()
    {
        this.audioSource = GetComponent<AudioSource>();
    }

    public void PlaySound(string action)
    {
        switch (action)
        {
            case "ATTACK":
                audioSource.clip = audioAttack;
                break;
        }
        audioSource.Play();
    }*/

    GameObject hpGauge;//Hp를 받아올 변수(이미지)
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("Hp");//HP를 찾아라
    }

    public void DecreasHP()//Hp감소 함수를 만듬
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;//0.1씩 감소
        if(this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("Gameend");//hp bqr가 0이하가 되면 Gameend로 넘어감
        }
    }

   
}
