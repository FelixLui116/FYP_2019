using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToGame3 : MonoBehaviour {

	// This script is to the other scene call level2

	public GameObject Player;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			//Player.gameObject.SetActive(false);			//Make it invisible
			SceneManager.LoadScene("level2");			//Load scene "Win02"
		}
	}
}
