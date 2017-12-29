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
    public void Jump()
    {
        player.jump = true;
    }
    public void StopJump()
    {
        player.jump = false;
    }
}