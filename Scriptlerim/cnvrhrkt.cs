using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cnvrhrkt    : MonoBehaviour
{

    private Rigidbody2D rb2;
    public float speed = 8;
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();
    }

    void Update()
    {


        rb2.velocity = new Vector2(speed, 0);

    }
}