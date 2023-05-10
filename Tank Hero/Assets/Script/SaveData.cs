using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveData : MonoBehaviour {

// This script is about saving the player data, health, coin, level, trophy

private PlayerHealth playerHealth;
private PlayerCoin playerCoin;
private Torphy1 playerTrophy;
private Trophy2 playerTrophy2;
private Trophy3 playerTrophy3;
private PlayerLevel playerLevelClass;

//private AbilityBase[] abilityBases;
//private TrophyBase[] trophys;


	// Use this for initialization
	void Start () {
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerCoin = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
		playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();


		playerTrophy = GameObject.FindGameObjectWithTag("Trophy").GetComponent<Torphy1>();
		playerTrophy2 = GameObject.FindGameObjectWithTag("Trophy2").GetComponent<Trophy2>();
		playerTrophy3 = GameObject.FindGameObjectWithTag("Trophy3").GetComponent<Trophy3>();
		//playerScore = GameObject.FindGameObjectWithTag("UI").GetComponent<ScoreScipt>();
	
	}
	
	// Update is called once per frame
	void Update () 
	{
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		//PlayerHealth playerHealth = gameObject.GetComponent<PlayerHealth>();
		//PlayerCoin playerCoin = gameObject.GetComponent<PlayerCoin>();
		
		if(collision.gameObject.tag == "Player")		//If collides with Player
		{
			PlayerPrefs.SetInt ("PlayerLevel", playerLevelClass.playerLevel);
			PlayerPrefs.SetInt ("PlayerExp", playerLevelClass.playerExp);

			PlayerPrefs.SetInt ("PlayerHP", playerHealth.health);
			PlayerPrefs.SetInt ("PlayerCoin", playerCoin.currentPlayerCoinc);
			PlayerPrefs.SetInt ("PlayerScore", ScoreScipt.scoreValue);

			PlayerPrefs.SetInt ("Trophy", playerTrophy.getTrophy1);
			PlayerPrefs.SetInt ("Trophy2", playerTrophy2.getTrophy2);
			PlayerPrefs.SetInt ("Trophy3", playerTrophy3.getTrophy3);

			/*for(int i = 0;i<trophys.Lenght;i++)
			{
				PlayerPrefs.SetInt ("Trophy"+ i.ToString(), trophys[i]);
			}*/

		/* for(int i = 0;i<trophys.Lenght;i++)
			{
				PlayerPrefs.SetInt ("Trophy"+ i.ToString(), trophys[i]);
			}
		*/
		}
	}

		

}
