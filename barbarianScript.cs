﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barbarianScript : MonoBehaviour
{
    Rigidbody2D rb;
     void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            jump();
        }
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * 12f, rb.velocity.y);
    }

    void jump()
    {
        rb.AddForce(transform.up * 14f, ForceMode2D.Impulse);
    }

}
