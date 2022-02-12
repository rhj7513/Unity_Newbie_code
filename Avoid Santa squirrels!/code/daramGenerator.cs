using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daramGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject poop;
    float respan = 0.5f;//복제 다람쥐가 나타나는 시간(리스폰 시간)
    float delta = 0;//일정한 시간을 비교하기 위한 시간 변수

    

    /* private void Start()
     {
         CreatePoop();
         StartCoroutine(CreatepoopRoutine());
     }

     IEnumerator CreatepoopRoutine()
     {
         while (true)
         {
             CreatepoopRoutine();
             yield return new WaitForSeconds(1);
         }
     }

     private void CreatePoop()
     {
         Vector3 pos = Camera.main.ViewportToWorldPoint(new Vector3(UnityEngine.Random.Range(0.0f,1.0f),1.1f,0));
         Instantiate(poop, pos, Quaternion.identity);
     }*/
    // Update is called once per frame
   private void Update()
    {
        this.delta = this.delta + Time.deltaTime;// this.delta += Time.deltaTime;
        if(this.delta > this.respan)
        {
            this.delta = 0;
            GameObject copyDaram = Instantiate(poop) as GameObject;
            float range = Random.Range(-6.0f, 6.0f);//Random.Range(최소값, 최대값)
            copyDaram.transform.position = new Vector3(range, 5, 0);
        }
      

    }

}
