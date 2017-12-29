using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour {

    public Rigidbody2D eb;
    public float movespeed = 20;
    public GameObject goEnemy;
    // Use this for initialization
    void Start () {
        eb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update () {
        eb.velocity = new Vector2(-movespeed, eb.velocity.y);
    }
    void OnBecameInvisible()
    {
        Destroy(goEnemy);
    }
}
