using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl3 : MonoBehaviour
{
    Animator animator;
    public bool LeftMove = false;
    public bool RightMove = false;
    float moveSpeed = 16;//버튼을 누르는 동안에 오브젝트의 움직이는 속도

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Vector3 moveVelocity = Vector3.zero;
        if (LeftMove)
        {
            moveVelocity = Vector3.left;
            transform.localScale = new Vector3(-1, 1, 1);//방향전환
        }
        if (RightMove)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);//이미지 좌우 반전
        }
        transform.position += moveVelocity * moveSpeed * Time.deltaTime;
    }
}
