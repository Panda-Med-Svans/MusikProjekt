using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTracker : MonoBehaviour {

    public static int scorePoints;
    public int currentPoints;

    public float currentPitch = 1;
    public float minPitch = 1f;
    public float maxPitch = 2f;
    public float smoothPitch = 5f;
    //[Tooltip("how much the pitch is increasing with each pick up. Min Pitch = 1, Max Pitch = 2")]
    public float pitchMultiplier = 0.15f;



    // instead of having the collectable play the sound. have the gameMaster do it (which also follows the character or something)

    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {

        //currentPoints = scorePoints;
        //Debug.Log(currentPitch + " & " + currentPoints);
        if(currentPitch > 1)
        {
            //currentPitch -= smoothPitch * Time.deltaTime; //Works but results in slightly lower pitch when it goes down to 1(0.99whatever)
            currentPitch = Mathf.Lerp(currentPitch, minPitch, Time.deltaTime);
        }
        //currentPitch = Mathf.Lerp(currentPitch, minPitch, Time.deltaTime);
    }
    public void PitchChange()
    {
        Debug.Log("Called");
        currentPitch += pitchMultiplier;
    }



}
