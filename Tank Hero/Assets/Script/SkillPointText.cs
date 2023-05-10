using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillPointText : MonoBehaviour {

	// This script is show the skill point text in the skill tree panel

	private int newSkillPoint;
	private PlayerSkillPoint playerSkillPoint;
	private Text playerSkillPointText;

	// Use this for initialization
	void Start () {
		playerSkillPointText = GetComponent<Text>();
		playerSkillPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSkillPoint>();
		newSkillPoint = playerSkillPoint.skillPoint;
	}
	
	// Update is called once per frame
	void Update () {
		newSkillPoint = playerSkillPoint.skillPoint;
		playerSkillPointText.text = "Skill Point:" + newSkillPoint;
	}
	
}
