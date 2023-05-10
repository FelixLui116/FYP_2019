using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarricadePlayer : MonoBehaviour {
	
	private PlayerHealth playerHealth;
	// Use this for initialization
	void Start () {

		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

		
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player")
		{
			ClickMe clickMe = other.gameObject.GetComponent<ClickMe>();
			clickMe.SpawnText ();
			
			playerHealth.health -=1;
			Destroy(gameObject);
		}
	}

}
