using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLevel : MonoBehaviour {

	// set the player level and need exp to levelUp
	public int playerLevel = 1;

	public int playerExp = 0;
	public int LevelUp = 10;
	private int resetLevel = 0;

	private PlayerHealth playerHealth;
	private PlayerSkillPoint playerSkillPoint;
	private LevelUpText levelUpText;
	private ProgressBar progressBar;
	
	// Use this for initialization
	void Start () {
		playerHealth = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerHealth>();
		playerSkillPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSkillPoint>();
		progressBar = GameObject.FindGameObjectWithTag("LevelBar").GetComponent<ProgressBar>();

	}
	
	// Update is called once per frame
	void Update () {
 		progressBar.BarValue = playerExp;
		if(playerExp >= LevelUp)
		{
			levelUpText = GameObject.FindGameObjectWithTag("Player").GetComponent<LevelUpText>();

			levelUpText.SpawnText();
			playerLevel++;
			playerSkillPoint.skillPoint +=1;
			if(playerHealth.health < 10){
			playerHealth.health +=1;	
			}
			
			playerExp = resetLevel;
		}
	}
}
