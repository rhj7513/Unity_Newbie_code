using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class first : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("space"))//GetKey-> �� �Է¹ޱ� (space bar)
        {
            SceneManager.LoadScene("GameScene");//Scene��ȯ (GameScene)
        }
    }
}
