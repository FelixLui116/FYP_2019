using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class ToGame2 : MonoBehaviour {

	// This script is to the other scene call level1 

	public GameObject Player;

	void OnCollisionEnter2D (Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			//Player.gameObject.SetActive(false);			//Make it invisible
			SceneManager.LoadScene("level1");			//Load scene "game02"
		}

		if(PlayerPrefs.GetInt("skill1")==1)
		{
			PlayerPrefs.SetInt("skill1", 0);
		}

		if(PlayerPrefs.GetInt("skill0")==1)
		{
			PlayerPrefs.SetInt("skill0", 0);
		}
	}


}
/*	public GameObject Player;							//Game Object Player
	void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log ("Enter!!");
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			Player.gameObject.SetActive(false);			//Make it invisible
			SceneManager.LoadScene("Game2");			//Load scene "Win02"
		}
	}*/
