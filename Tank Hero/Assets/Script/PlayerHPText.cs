using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHPText : MonoBehaviour {

	//This script is the UI Player HP Text, it show the current HP

	private int playerHP;
	private PlayerHealth playerHealth;
	private Text healthText;
	// Use this for initialization
	void Start () {
		healthText = GetComponent<Text>();
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerHP = playerHealth.health;
	}
	
	// Update is called once per frame
	void Update () {
		playerHP = playerHealth.health;
		//print(playerHP);
		healthText.text = "HP:" + playerHP;
	}
}
