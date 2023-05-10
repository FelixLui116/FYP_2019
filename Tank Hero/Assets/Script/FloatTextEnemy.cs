using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatTextEnemy : MonoBehaviour {

	public int PointsToGivePlayer;
	public string TextToShow;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

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
