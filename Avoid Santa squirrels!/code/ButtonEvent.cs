using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonEvent : MonoBehaviour
{
    GameObject player;
    PlayerControl3 playerControl3;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("player");
        playerControl3 = player.GetComponent<PlayerControl3>();
    }
    public void LeftDown()
    {
        playerControl3.LeftMove = true;
    }
    public void Leftup()
    {
        playerControl3.LeftMove = false;
    }
    public void RightDown()
    {
        playerControl3.RightMove = true;
    }
    public void RightUp()
    {
        playerControl3.RightMove = false;
    }
}
