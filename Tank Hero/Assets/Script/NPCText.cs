using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCText : MonoBehaviour {

	//This script is about the NPC show the text to the player

	public int PointsToGivePlayer;
	public string TextToShow;


	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Player")
		{
			SpawnText();
		}
	}

	public void SpawnText() 
	{
		GameObject PointsText = Instantiate(Resources.Load("Prefabs/NPCtalk")) as GameObject;
		
		if(PointsText.GetComponent<TextOnSpotScript>() != null) {
			var givePointsText = PointsText.GetComponent<TextOnSpotScript>();
			givePointsText.DisplayPoints = PointsToGivePlayer;
			givePointsText.DisplayText = TextToShow;
			//print("Hit number");
		}
		PointsText.transform.position = gameObject.transform.position;
	}
}
