﻿using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{

    public float speed = 150f;
    public Vector2 maxVelocity = new Vector2(60, 100);

    private Rigidbody2D body2D;
    private SpriteRenderer renderer2D;

    // Use this for initialization
    void Start()
    {
        body2D = GetComponent<Rigidbody2D>();
        renderer2D = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {

        var absVelocityX = Mathf.Abs(body2D.velocity.x);
        var forceX = 0f;
        var forceY = 0f;
        if (Input.GetKey("right"))
        {
            if (absVelocityX < maxVelocity.x)
            {
                forceX = speed;
            }
            renderer2D.flipX = false;
        }
        else if (Input.GetKey("left"))
        {
            if (absVelocityX < maxVelocity.x)
            {
                forceX = -speed;
            }
            renderer2D.flipX = true;

        }
        body2D.AddForce(new Vector2(forceX, forceY));
    }
}
