using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoRotate : MonoBehaviour {

    public float rotationX;
    public float rotationY;
    public float rotationZ;
    private float rotationSpeed = 90f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(rotationX, rotationY, rotationZ) * rotationSpeed * Time.deltaTime);
    }
}
