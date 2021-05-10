using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //class wide variables
    // creates new variable for movement speed of character game object
    // creates a new rigid body 2d to give physics to character(collision)
    public float movementSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 movement;

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        //input
    }
    // Update is called at fixed interval of frames(called 50 times per sec)
    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * movementSpeed * Time.fixedDeltaTime);
        //moves rigid body to new position and collide with anthing in the way
        //movement
    }
}
