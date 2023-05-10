using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreScipt : MonoBehaviour {

	// This script is about score text in the UI

	public static int scoreValue = 0;
	public Text score;

	// Use this for initialization
	void Start () {
		score = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		score.text = "Score:" + scoreValue;
	}
}
