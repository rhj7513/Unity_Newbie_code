using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCon : MonoBehaviour
{
    float speed = 0;//������Ʈ�� �̵��ϱ� ���� �ʿ���  ���� ����
    Vector2 startPos;//���콺�� ������ ��
    //2���� ��ǥ�� ����(x,y) 3���� ��ǥ�� ���Ͱ�(x,y,z)
    //Vecor2�� 2���� ��ǥ���� �����ϴ�.(xy) Vector3(x,y,z)
    Vector2 endPos;//���콺�� ������ ������ ���� ��ġ���� �� ����
    public float �и� = 1000.0f;//�и�
    bool leftFlag = false;//������ȯ�� ���� ����������(�Һ���)
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//���콺 ���ʹ�ư�� ������
        {
            this.startPos = Input.mousePosition;//���콺��ư���� ������ ���� ��ġ��(x,y)
            leftFlag = false;//�� �Ǵ� ���� ���� �����ϴ� ��
        }
        else if (Input.GetMouseButtonUp(0))
        {
            this.endPos = Input.mousePosition;//���콺 ��ư�� �����ٰ� ������ ���� ��ġ��(x,y)
            float length = (this.endPos.x - this.startPos.x);//endpos - startpos�� ���� �̵��ӵ��� �̿��� �� �׸��� �� ���� length�� �����Ѵ�. length������ speed ������ ������ ���̴�.
            //������ ��ǥ�� - ó�� ��ǥ���� ���ݴϴ�.
            this.speed = length / �и�;//length���� speed���� �����Ѵ�. speed���� Translate x�� �����Ͽ� ������Ʈ�� �̵��ϰ� �Ѵ�.
            this.GetComponent<AudioSource>().Play();
            leftFlag = true;
        }

        transform.Translate(this.speed* Time.deltaTime, 0, 0);//�̵� x+����
        transform.Translate(this.speed , 0, 0);//�̵� x+����
        this.speed *= 0.98f;//����
        this.GetComponent<SpriteRenderer>().flipX = leftFlag;








        /*if (Input.GetMouseButton(0))//���콺 ���ʹ�ư�� ������
        {
            this.speed = 0.1f;//ó���ӵ��� �����ؼ� ����
        }
        if (Input.GetMouseButton(1))//���콺 ���ʹ�ư�� ������
        {
            this.speed = -0.1f;
        }
        transform.Translate(this.speed, this.speed, 0);//�̵� x+����
        this.speed *= 0.98f;//����*/
    }
}
