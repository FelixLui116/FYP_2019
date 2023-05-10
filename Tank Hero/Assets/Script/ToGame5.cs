using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame5 : MonoBehaviour {

	// This script is to the other scene call Boss level 

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	}
	void OnCollisionEnter2D (Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			//Player.gameObject.SetActive(false);			//Make it invisible
			SceneManager.LoadScene("BossLevel");			//Load scene "Win02"
		}
	}
}
