using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOver1 : MonoBehaviour {

	//This script is player game over to the scnce,  resset the HP score and LV

	private PlayerCoin playerCoin;
	private ScoreScipt playerScore;
	private PlayerHealth playerHealth;
	private PlayerLevel playerLevelClass;
	private SkillTreeButton skillTreeButton;
	//private PlayerLevel playerLevelClass;

	//public GameObject gameOverPanel;
	// Use this for initialization
	void Start () {	
		playerCoin = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
		playerScore = GameObject.FindGameObjectWithTag("UI").GetComponent<ScoreScipt>();
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();
		skillTreeButton = GameObject.FindGameObjectWithTag("Player").GetComponent<SkillTreeButton>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void playAgainLevel_1()
	{
		SceneManager.LoadScene("level1");
		
		//gameOverPanel.SetActive(false);
	}

	public void playAgainLevel_2()
	{
		SceneManager.LoadScene("level2");

		//gameOverPanel.SetActive(false);
	}

	public void playAgainLevel_3()
	{
		SceneManager.LoadScene("level3");
		

		//gameOverPanel.SetActive(false);
	}

	public void playAgainBossLevel_1()
	{
		SceneManager.LoadScene("BossLevel");
		

		//gameOverPanel.SetActive(false);
	}

	public void BackToMain()
	{
		SceneManager.LoadScene("Menu");

		//PlayerPrefs.DeleteAll ();
		//gameOverPanel.SetActive(false);
	}

	public void resetPlayerCoinData ()
	{
		playerCoin.currentPlayerCoinc = 0;
		PlayerPrefs.SetInt ("PlayerCoin", playerCoin.currentPlayerCoinc);
		PlayerPrefs.DeleteAll();
	}

	public void resetPlayerScoreData ()
	{
		ScoreScipt.scoreValue = 0;
		PlayerPrefs.SetInt ("PlayerScore", ScoreScipt.scoreValue);
	}

	public void resetPlayerHealthData ()
	{
		playerHealth.health = 10;
		PlayerPrefs.SetInt ("PlayerHP", playerHealth.health);
	}

	public void resetPlayerLevelData ()
	{
		playerLevelClass.playerLevel = 1;
		PlayerPrefs.SetInt ("PlayerLevel", playerLevelClass.playerLevel);
	}

	public void resetPlayerSkill ()
	{
		PlayerPrefs.SetInt ("Skill", 0);
	}

	public void resetPlayerExpData ()
	{
		playerLevelClass.playerExp = 0;
		PlayerPrefs.SetInt ("PlayerExp", playerLevelClass.playerExp);
	}
}
