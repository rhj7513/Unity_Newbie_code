using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()//1초에 60~80 정도 움직임
    {
        
    }
    void FixedUpdate()//1초에 50번 정도 움직임
    {
        this.transform.Translate(0.1f, 0, 0);
    }
}
