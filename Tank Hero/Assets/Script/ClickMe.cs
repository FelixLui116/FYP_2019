using UnityEngine;
using System.Collections;

public class ClickMe : MonoBehaviour {

	public int PointsToGivePlayer;
	public string TextToShow;


	public void SpawnText() 
	{
		GameObject PointsText = Instantiate(Resources.Load("Prefabs/TextOnSpot2")) as GameObject;
		
		if(PointsText.GetComponent<TextOnSpotScript>() != null) {
			var givePointsText = PointsText.GetComponent<TextOnSpotScript>();
			givePointsText.DisplayPoints = PointsToGivePlayer;
			givePointsText.DisplayText = TextToShow;
			//print("Hit number");
			
		}
		PointsText.transform.position = gameObject.transform.position;
	}
}
