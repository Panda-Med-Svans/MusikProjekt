using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //public PickUpOwls owlScript;


    // Use this for initialization
    void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            //TODO: add score, play sound
        }
        //if (other.gameObject.CompareTag("Owl"))
        //{
        //    owlScript.Test(); //
        //    other.gameObject.SetActive(false);
        //    //TODO: create interaction to unlock, add music part to existing one
        //}
    }
}
