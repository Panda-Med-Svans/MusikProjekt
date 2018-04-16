using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpOwls : MonoBehaviour {

    public GameObject owl;
    //private <OtherScript> Instruments;
    
	// Use this for initialization
	void Start () {
        owl = this.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Test()
    {
        Debug.Log("Collected Owl");
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag ("Player"))
        {
            Debug.Log("Destroyed");
            owl.SetActive(false);
            //add instrument to song
            //DestroyObject(owl);
        }


    }


}
