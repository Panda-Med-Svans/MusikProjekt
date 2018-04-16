using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    public float speed = 6f;
    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;

    private Vector2 moveDirection = Vector2.zero;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        CharacterController player = GetComponent<CharacterController>();
        if (player.isGrounded)
        {
            moveDirection.y = 0;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }
        else
        {
            moveDirection.y -= gravity * Time.deltaTime;
        }

        moveDirection.x = speed;

        player.Move(moveDirection * Time.deltaTime);
    }
}
