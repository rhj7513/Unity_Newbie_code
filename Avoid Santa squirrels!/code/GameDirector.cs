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

    GameObject hpGauge;//Hp�� �޾ƿ� ����(�̹���)
    // Start is called before the first frame update
    void Start()
    {
        this.hpGauge = GameObject.Find("Hp");//HP�� ã�ƶ�
    }

    public void DecreasHP()//Hp���� �Լ��� ����
    {
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;//0.1�� ����
        if(this.hpGauge.GetComponent<Image>().fillAmount <= 0)
        {
            SceneManager.LoadScene("Gameend");//hp bqr�� 0���ϰ� �Ǹ� Gameend�� �Ѿ
        }
    }

   
}
