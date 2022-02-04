using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))//GetKey-> 값 입력받기 (space bar)
        {
            SceneManager.LoadScene("GameScene");//Scene변환 (GameScene)
        }
    }
}
