using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour {

    public Rigidbody2D rb;
    public float movespeed;
    public bool moveright;
    public bool moveleft;
    public bool jump;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }

    void Update()
    {
        if (jump)
        {
            rb.AddForce(new Vector2(0, 1), ForceMode2D.Impulse);
        }
    }
}
