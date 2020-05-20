﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CharacterController : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private bool facingRight = true;
    public float speed;

    public float inForestSpeed;

    private static bool playerInForest;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }


    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        rb2d.velocity = new Vector2(moveHorizontal * speed, rb2d.velocity.y);

        if (facingRight == false && moveHorizontal > 0)
        {
            Flip();
        }
        else if (facingRight == true && moveHorizontal <0)
        {
            Flip();
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            if (playerInForest)
            {
                inRoad();
            }
            else
            {
                inForest();
            }
        }
    }

    void inForest()
    {
        //transform.position = new Vector3(transform.position.x, transform.position.y, 1);
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 1;
        speed = inForestSpeed;
        playerInForest = true;
    }

    void inRoad()
    {
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = 3;
        //speed = speed;
    }

    void Flip()
    {
        facingRight = !facingRight;
        Vector2 Scaler = transform.localScale;
        Scaler.x = Scaler.x * -1;
        transform.localScale = Scaler;
    }
}
