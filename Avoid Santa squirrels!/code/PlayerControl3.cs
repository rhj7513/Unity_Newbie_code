using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl3 : MonoBehaviour
{
    Animator animator;
    public bool LeftMove = false;
    public bool RightMove = false;
    float moveSpeed = 16;//��ư�� ������ ���ȿ� ������Ʈ�� �����̴� �ӵ�

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
            transform.localScale = new Vector3(-1, 1, 1);//������ȯ
        }
        if (RightMove)
        {
            moveVelocity = Vector3.right;
            transform.localScale = new Vector3(1, 1, 1);//�̹��� �¿� ����
        }
        transform.position += moveVelocity * moveSpeed * Time.deltaTime;
    }
}
