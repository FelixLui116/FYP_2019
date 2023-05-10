using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinText : MonoBehaviour {

	private int newplayerCoin;
	private PlayerCoin playerCoin;
	private Text coinText;
	// Use this for initialization
	void Start () {
		coinText = GetComponent<Text>();
		playerCoin = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerCoin>();
		newplayerCoin = playerCoin.currentPlayerCoinc;
	}
	
	// Update is called once per frame
	void Update () {
		newplayerCoin = playerCoin.currentPlayerCoinc;
		coinText.text = "Coin:" + newplayerCoin;
	}
}
