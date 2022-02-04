using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : BaseMeshEffect
{
    public Gradient myGradient;//������� ���� Gradient->�÷��� ������ �ִ�.
    public override void ModifyMesh(VertexHelper vh)
    {
        List<UIVertex> vertices = new List<UIVertex>();
        vh.GetUIVertexStream(vertices);

        for(int i = 0; i< vertices.Count; i++)
        {
            var v = vertices[i];
            v.color = new Color(Random.value, Random.value, Random.value, 1);//�������� �� ���
            vertices[i] = v;
        }

        vh.Clear();//�� ���ֹ�����
        vh.AddUIVertexTriangleStream(vertices);
    }
}
