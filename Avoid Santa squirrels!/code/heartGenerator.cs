using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartGenerator : MonoBehaviour
{
    public GameObject 복제심장;
    float respan = 1.0f;//복제 심장이 나타나는 시간(리스폰 시간)
    float delta = 0;//일정한 시간을 비교하기 위한 시간 변수

    // Update is called once per frame
    void Update()
    {
        this.delta = this.delta + Time.deltaTime;// this.delta += Time.deltaTime;
        if (this.delta > this.respan)
        {
            this.delta = 0;
            GameObject copyHeart = Instantiate(복제심장) as GameObject;
            float range = Random.Range(-6.0f, 6.0f);//Random.Range(최소값, 최대값)
            copyHeart.transform.position = new Vector3(range, 10, 0);
        }
    }
}
