using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public float moveSpeed;

    public float groundDrag;

    float horizontalInput;
    float verticalInput; 

    Vector3 moveDirection;

    Rigidbody rb;

    void Start()
    {
        //Freezes rotation so player object doesn't move with the camera 
        rb = GetComponent<Rigidbody>();
    }

    void Update() 
    {
        PlayerInput();
        SpeedControl();
    }

    void FixedUpdate()
    {
        MovePlayer();
    }

    void PlayerInput()
    {
       horizontalInput = Input.GetAxisRaw("Horizontal");
       verticalInput = Input.GetAxisRaw("Vertical");
    }

    void MovePlayer() 
    {
        //Calculates movement direction
        moveDirection = new Vector3(horizontalInput, 0f, verticalInput);

        rb.velocity = new Vector3(moveDirection.x * moveSpeed, rb.velocity.y, moveDirection.z * moveSpeed);

    }
    void SpeedControl() 
    {
        Vector3 flatVel = new Vector3(rb.velocity.x, 0f, rb.velocity.z);
        //Limits velocity if required
        if (flatVel.magnitude > moveSpeed) 
        {
            Vector3 limitedVel = flatVel.normalized * moveSpeed;
            rb.velocity = new Vector3(limitedVel.x, rb.velocity.y, limitedVel.z); 
        }
    }
}
