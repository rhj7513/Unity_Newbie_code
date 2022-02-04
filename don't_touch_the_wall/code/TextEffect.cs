using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextEffect : BaseMeshEffect
{
    public Gradient myGradient;//멤버변수 선언 Gradient->컬러값 가지고 있다.
    public override void ModifyMesh(VertexHelper vh)
    {
        List<UIVertex> vertices = new List<UIVertex>();
        vh.GetUIVertexStream(vertices);

        for(int i = 0; i< vertices.Count; i++)
        {
            var v = vertices[i];
            v.color = new Color(Random.value, Random.value, Random.value, 1);//랜덤으로 색 출력
            vertices[i] = v;
        }

        vh.Clear();//다 없애버리기
        vh.AddUIVertexTriangleStream(vertices);
    }
}
