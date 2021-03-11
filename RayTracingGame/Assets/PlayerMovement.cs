﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;
    // Update is called once per frame
    void Update()//handle input here
    {
        facemouse();
        movement.x =Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate() { //handle movement here
        rb.MovePosition(rb.position + movement * moveSpeed* Time.fixedDeltaTime);
    
    }
    void facemouse() {

        Vector2 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        Vector2 direction = new Vector2(mousePosition.x -transform.position.x, mousePosition.y - transform.position.y);
        transform.up = direction;
    
    }
}
