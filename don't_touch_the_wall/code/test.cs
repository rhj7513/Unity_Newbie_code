using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class test : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    //OnTriggerEnter2D�Լ��� Star,Update�� ���� "����Ƽ�� ����� �Լ�"�̴�.
    //����Ƽ���� "Ʈ���Ű� Ȱ��ȭ�Ǿ��� ��" �����ϴ� �Լ��̴�.
    // Ʈ���� Ȱ�� -> player ������Ʈ�� Is Trigger�� üũ�� �Ǿ��ִ� �ٸ� ��ü�� �浹�ߴٴ� ���� ���Ѵ�.
    {
        if (collision.CompareTag("��ֹ�")) //CompareTag�� �±׸� Ȯ���ϴ� �Լ� -> ��ֹ��±׸� �ش�
        {
            player();//�Լ� ȣ��
            SceneManager.LoadScene("GameOver");//Scene����(GameOver)
        }
        else if (collision.CompareTag("����"))//-> �����±׸� �ش�
        {
            player();//�Լ� ȣ��
            SceneManager.LoadScene("GameWin");//Scene����(GameWin)
        }

    }

    public void player()//�Լ� �߰�
    {
        Destroy(gameObject);//Destroy�� ��ȣ �ȿ� ���ִ� ������Ʈ�� �ı��ϴ� ��ɾ�
        //gameObject�� "�� �ڽ�"�� ���Ѵ�. -> player ������Ʈ �����
    }
}
