using UnityEngine;
using System.Collections;

public class Touch : MonoBehaviour
{
    private Controls player;

    void Start()
    {
        player = FindObjectOfType<Controls>();
        Debug.Log(player);
    }

    public void LeftArrow()
    {
        Debug.Log("LeftArrow");
        player.moveright = false;
        player.moveleft = true;
    }
    public void RightArrow()
    {
        Debug.Log("RightArrow");
        player.moveright = true;
        player.moveleft = false;
    }
    public void ReleaseLeftArrow()
    {
        Debug.Log("RelLeftArrow");
        player.moveleft = false;
    }
    public void ReleaseRightArrow()
    {
        Debug.Log("RelRightArrow");
        player.moveright = false;
    }
    public void Jump()
    {
        player.jump = true;
    }
    public void StopJump()
    {
        player.jump = false;
    }
}