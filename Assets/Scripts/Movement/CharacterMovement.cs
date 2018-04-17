using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    //public something tiltAngle;
    
    public float startSpeed = 6f;
    private float currentSpeed;
    public float minSpeed;
    public float maxSpeed;
    public float smoothTime;

    public float jumpSpeed = 8.0f;
    public float gravity = 20.0f;


    private Vector2 moveDirection = Vector2.zero;

    private CharacterController player;

    // Use this for initialization
    void Start()
    {
        currentSpeed = startSpeed;
        player = GetComponent<CharacterController>(); 
        //flyttade från FixedUpdate till hit
    }
    
    // Update is called once per frame
    void FixedUpdate()
    {
        #region placeholder Tilt speed
        //Debug.Log(currentSpeed);
        ////placeholder for tilt speed.
        //if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)) 
        //{
        //    if(currentSpeed <= maxSpeed)
        //    {
        //        currentSpeed = Mathf.Lerp(currentSpeed, maxSpeed, (smoothTime * Time.deltaTime));
        //    }
        //}
        //if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        //{
        //    if (minSpeed <= currentSpeed)
        //    {
        //        currentSpeed = Mathf.Lerp(currentSpeed, minSpeed, (smoothTime * Time.deltaTime));
        //    }
        //}
        //else
        //{
        //    currentSpeed = Mathf.Lerp(currentSpeed, startSpeed, (smoothTime * Time.deltaTime));
        //}
        #endregion

        //CharacterController player = GetComponent<CharacterController>(); //(behöver den hitta komonenten varje update?)
        if (player.isGrounded) //
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

        moveDirection.x = currentSpeed;

        player.Move(moveDirection * Time.deltaTime);
    }
}
