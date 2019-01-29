using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMotor : MonoBehaviour
{
    float moveSpeed = 4;
    float gravity = 6;

    Vector3 moveDirection;

    CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController> ();
    }

    void Update()
    {
        
    }

    void Move()
    {
        float moveX = Input.GetAxis ("Horizontal");
        float moveZ = Input.GetAxis ("Vertical");

        if (controller.isGrounded)
        {
            moveDirection = new Vector3(moveX, 0, moveZ);
        }

    }
}