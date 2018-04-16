using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterJump : MonoBehaviour {

    public int numberOfDoubleJumps = 1;
    private int doubleJumpCount = 0;
    public float jumpSpeed = 5f;
    public Rigidbody rb;

    // Use this for initialization
    void Start () {
        doubleJumpCount = numberOfDoubleJumps;
        rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log(doubleJumpCount);
        if (Input.GetKeyDown(KeyCode.Space) && doubleJumpCount <= numberOfDoubleJumps)
        {
            rb.velocity += jumpSpeed * Vector3.up;
            doubleJumpCount++;
        }
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            doubleJumpCount = 0;
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
}
