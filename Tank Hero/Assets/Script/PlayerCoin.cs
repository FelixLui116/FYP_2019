using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCoin : MonoBehaviour {

	//This script is the player collider the coin and add the coin

	public int currentPlayerCoinc = 0;

	//public GetCoin getCoin;

	public AudioSource playerGetCoinSound;



	// Use this for initialization
	void Start () {
		//getCoin = GameObject.FindGameObjectWithTag("Coin").GetComponent<GetCoin>();
	
		playerGetCoinSound = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	// Collider to coin add 100 coin to the player and destroy object
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Coin")
		{	
			//getCoin.CoinSound();
			playerGetCoinSound.Play();
			currentPlayerCoinc +=100;
			Destroy(other.gameObject);
			print("Get Coin");
			//currentPlayerCoinc +=100;
		}
	}
}
