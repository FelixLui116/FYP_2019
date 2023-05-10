using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetCoin : MonoBehaviour {

	public AudioSource playerGetCoinSound;

	private  PlayerCoin plyerClass;

	//This script is play the audio of coin 
  void Start () {
		playerGetCoinSound = GetComponent<AudioSource>();

		plyerClass = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
	
	}

	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			//CoinSound();
		}
	}

	public void CoinSound()
	{
		playerGetCoinSound.Play();
		print("Sound Coin");
	}
}
	/* void OnTriggerEnter2D(Collider2D other)
	{
	if (other.gameObject.tag == "Player")
		{
			playerGetCoinSound.Play();
			print("Sound Coin");
			//Destroy(gameObject);
		}
	}*/
