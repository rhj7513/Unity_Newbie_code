using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Act : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("space"))//GetKey-> 값 입력받기 (space bar)
        {
            SceneManager.LoadScene("GameWin");//Scene변환 (GameWin)
        }
    }
}
