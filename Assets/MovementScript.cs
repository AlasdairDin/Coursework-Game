using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementScript : MonoBehaviour
{
    CharacterController characterController;

    public float sprintSpeed = 12f;
    public float walkSpeed = 8.0f;
    public float jumpSpeed = 10.0f;
    public float gravity = 20.0f;

    private Vector3 moveDirection = Vector3.zero;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    void Update()
    {
        if (characterController.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= walkSpeed;
            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        moveDirection.y -= gravity * Time.deltaTime;
        characterController.Move(moveDirection * Time.deltaTime);
        if (Input.GetKey(KeyCode.LeftShift))
        {
            walkSpeed = sprintSpeed;
        }
        else

        {
            walkSpeed = walkSpeed;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            walkSpeed = 4f;
        }
    }
}
