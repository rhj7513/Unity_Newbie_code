using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class daramGenerator : MonoBehaviour
{
    [SerializeField]
    public GameObject poop;
    float respan = 0.5f;//���� �ٶ��㰡 ��Ÿ���� �ð�(������ �ð�)
    float delta = 0;//������ �ð��� ���ϱ� ���� �ð� ����

    

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
            float range = Random.Range(-6.0f, 6.0f);//Random.Range(�ּҰ�, �ִ밪)
            copyDaram.transform.position = new Vector3(range, 5, 0);
        }
      

    }

}
