using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetPotion : MonoBehaviour {


	//This script is the player buy the potion and lose coin to get health 

	//public GameObject PotionPanel;
	//private int playerHP;
	//private PlayerHealth playerHealth;
	// Use this for initialization
	void Start () {
		/* playerHealth = GetComponent<PlayerHealth>();
		playerHP = playerHealth.health;
		print("get PlayerHealth");*/
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Player")
		{

			PlayerCoin playerCoin = other.gameObject.GetComponent<PlayerCoin>();
			if(playerCoin.currentPlayerCoinc >=500)
			{
				playerCoin.currentPlayerCoinc-=500;
				print("Coin-100");

				PlayerHealth playerHealth = other.gameObject.GetComponent<PlayerHealth>();
				print("get potion");
				if(playerHealth.health < 10)
				{
					playerHealth.health+= 3;
				}
           	 	

				Destroy(gameObject);
			}


		}
	}
/* 
	public void GoPotionPanel()
	{
		 if(PotionPanel != null)
		{
            //pause Time
			if(Time.timeScale == 1)
			Time.timeScale = 0;
			else
			Time.timeScale = 1;
            print("GoPotionPanel");
			PotionPanel.SetActive(true);
		}
	}*/
}
