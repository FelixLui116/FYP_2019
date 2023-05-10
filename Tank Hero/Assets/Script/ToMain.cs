using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class ToMain : MonoBehaviour {

	// This script is reset the coin and score when the player back to main menu

	private PlayerCoin playerCoin;
	private ScoreScipt playerScore;
	//private PlayerHealth playerHealth;
	//private PlayerLevel playerLevelClass;
	//private SkillTreeButton skillTreeButton;

	// Use this for initialization
	void Start () {
		playerCoin = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
		playerScore = GameObject.FindGameObjectWithTag("UI").GetComponent<ScoreScipt>();
		//playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		//playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();
		//skillTreeButton = GameObject.FindGameObjectWithTag("Player").GetComponent<SkillTreeButton>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			//Player.gameObject.SetActive(false);			//Make it invisible
			SceneManager.LoadScene("Menu");			//Load scene "Win02"

			playerCoin.currentPlayerCoinc = 0;
			PlayerPrefs.SetInt ("PlayerCoin", playerCoin.currentPlayerCoinc);
			
			ScoreScipt.scoreValue = 0;
			PlayerPrefs.SetInt ("PlayerScore", ScoreScipt.scoreValue);
		}
	}
}
