using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectSound : MonoBehaviour {

    private AudioSource leafCollect;
    private AudioClip leafAudioClip;
    public GameObject gameMaster;
    public ScoreTracker pitchChange;
    public float theChange = 0.15f;

    // Use this for initialization
    void Start()
    {
        leafCollect = GetComponent<AudioSource>();
        leafAudioClip = leafCollect.clip;
        //move to gameMaster instead. to be able to use the pitch change.
       
        pitchChange = gameMaster.GetComponent<ScoreTracker>();
    }


    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collided with " + other.name);
        if (other.name == "Player")
        {
            //Debug.Log("playing sound");
            AudioSource.PlayClipAtPoint(leafAudioClip, transform.position);
            Score();
            Destroy(gameObject); // this destroys the collider as well
        }
        
    }


    void Score()
    {
        pitchChange.PitchChange();
        ScoreTracker.scorePoints++; //move to Score Tracker instead
        //Debug.Log("sending score tracker info that it should increase the score");
    }





}
