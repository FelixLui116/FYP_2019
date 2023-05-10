using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadData : MonoBehaviour {

//This script is load the data from playerPrets

private PlayerHealth playerHealth;
private PlayerCoin playerCoin;
private ScoreScipt playerScore;
private Torphy1 playerTrophy;
private Trophy2 playerTrophy2;
private Trophy3 playerTrophy3;
private PlayerLevel playerLevelClass;

public GameObject[] skills;

public SkillTreeButton skillTreeButton;

//skillTreeButton. GameObject[] skills


/* private bool[3] Torphy; */

	// Use this for initialization
	void Start () {
		
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerCoin = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
		playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();

		playerTrophy = GameObject.FindGameObjectWithTag("Trophy").GetComponent<Torphy1>();
		playerTrophy2 = GameObject.FindGameObjectWithTag("Trophy2").GetComponent<Trophy2>();
		playerTrophy3 = GameObject.FindGameObjectWithTag("Trophy3").GetComponent<Trophy3>();

		//playerScore = GameObject.FindGameObjectWithTag("Player").GetComponent<ScoreScipt>();
		
		playerCoin.currentPlayerCoinc = PlayerPrefs.GetInt("PlayerCoin");
		playerHealth.health = PlayerPrefs.GetInt("PlayerHP");
		ScoreScipt.scoreValue = PlayerPrefs.GetInt("PlayerScore");
		playerLevelClass.playerLevel = PlayerPrefs.GetInt("PlayerLevel");
		playerLevelClass.playerExp = PlayerPrefs.GetInt("PlayerExp");


		playerTrophy.getTrophy1 = PlayerPrefs.GetInt("Trophy");
		playerTrophy2.getTrophy2 = PlayerPrefs.GetInt("Trophy2");
		playerTrophy3.getTrophy3 = PlayerPrefs.GetInt("Trophy3");
		 
		for(int i = 0; i< skills.Length; i++)
		{
			print(PlayerPrefs.GetInt ("skill"+i.ToString()));
			
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
