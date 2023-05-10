using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUpText : MonoBehaviour {

	//This script is show the levelup text

	public int PointsToGivePlayer;
	public string TextToShow;

	/* void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "bulletEnemy")
		{
			SpawnText ();

			print("Hit number");
		}
	}*/
	/* public void OnMouseDown ()
	{
		
		SpawnText ();

		print("Hit number");
	}*/

	public void SpawnText() 
	{
		GameObject PointsText = Instantiate(Resources.Load("Prefabs/LevelUpText")) as GameObject;
		
		if(PointsText.GetComponent<TextOnSpotScript>() != null) {
			var givePointsText = PointsText.GetComponent<TextOnSpotScript>();
			givePointsText.DisplayPoints = PointsToGivePlayer;
			givePointsText.DisplayText = TextToShow;
			//print("Hit number");
			
		}
		PointsText.transform.position = gameObject.transform.position;
	}
}
