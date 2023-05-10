using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerLevelText : MonoBehaviour {

	// This script is show the level of the player text 
	private int playerLv;
	private PlayerLevel playerLevelClass;
	private Text playerLevelText;
	// Use this for initialization
	void Start () {
		playerLevelText = GetComponent<Text>();
		playerLevelClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerLevel>();
		playerLv = playerLevelClass.playerLevel;
	}
	
	// Update is called once per frame
	void Update () {
		playerLv = playerLevelClass.playerLevel;
		print(playerLv);
		playerLevelText.text = "Lv:" + playerLv;
	}
}
