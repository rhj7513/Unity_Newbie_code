using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UI_Act : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("space"))//GetKey-> �� �Է¹ޱ� (space bar)
        {
            SceneManager.LoadScene("GameWin");//Scene��ȯ (GameWin)
        }
    }
}
