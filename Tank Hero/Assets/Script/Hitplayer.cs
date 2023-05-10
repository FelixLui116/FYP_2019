using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hitplayer : MonoBehaviour {
	// Use this for initialization

	public AudioSource playerHitSound;

	//This script is play the audio of player hit and lose HP

	void Start () {
		playerHitSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D other)
    {  	        
		if(other.gameObject.tag == "Player")
        {
			PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
			ClickMe clickMe = other.gameObject.GetComponent<ClickMe>();

			clickMe.SpawnText ();
			//print("hit get");
			
            playerHealth.health--;
			//print("hit");
			//playerHitSound.Play();
        }
    }
}
