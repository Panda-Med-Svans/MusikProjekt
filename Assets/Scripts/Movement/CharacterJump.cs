using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    private bool isGrounded = false;
    private bool hasJumped = false;
    private bool canDoubleJump = false;
    public float delayBeforeDoubleJump;




    //public int numberOfDoubleJumps = 1;
    //private int doubleJumpCount = 0;
    public float jumpSpeed = 5f;
    public Rigidbody rb;

    void Start () {
        //doubleJumpCount = numberOfDoubleJumps;
        rb = GetComponent<Rigidbody>();
	}

    //void FixedUpdate()
    //{
    //    Debug.Log(doubleJumpCount);
    //    if (Input.GetButtonDown("Jump") && doubleJumpCount <= numberOfDoubleJumps)//gör doubleJumpCount till bool, hasDoubleJumped
    //    {
    //        rb.velocity += jumpSpeed * Vector3.up;
    //        doubleJumpCount++;
    //    }
    //}

    void FixedUpdate()
    {
        //Debug.Log("isGrounded is " + isGrounded + " & canDoubleJump is " + canDoubleJump);
        if (Input.GetButtonDown("Jump"))
        {
            if(isGrounded)
            {
                Jump();
            }
            if(canDoubleJump)
            {
                Jump();
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            hasJumped = false;
            canDoubleJump = false;
        }
        if (collision.gameObject.tag == "Bad")
        {
            Bad();
        }
    }

    void Bad()
    {
        //TODO something when you touch bad
    }

    void Jump()
    {
        if(isGrounded)
        {
            hasJumped = true;
            isGrounded = false;
            rb.velocity += jumpSpeed * Vector3.up;
            Invoke("EnableDoubleJump", delayBeforeDoubleJump);
            //TODO: link animation, sound etc
        }
        if (canDoubleJump)
        {
            canDoubleJump = false;
            rb.velocity += jumpSpeed * Vector3.up;
            //TODO: link animation, sound etc
        }
    }
    void EnableDoubleJump()
    {
        canDoubleJump = true;
    }
}
