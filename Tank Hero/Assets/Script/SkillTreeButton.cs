using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillTreeButton : MonoBehaviour {

	// This script is about the player use the skill point to upgrade skill and using array list save skill
	// Abilitu Base using array list to create the skill.

	public GameObject skillsPanel;

	public GameObject skill2;

	public GameObject skillShootUp;
	public GameObject[] skills;

	//public int savedSkill2;

	private PlayerSkillPoint playerSkillPoint;

	private AbilityBase[] abilityBases;

	// Use this for initialization
	public void OpenSkillsMenu () {
		if(skillsPanel != null)
		{
			bool isActive = skillsPanel.activeSelf;

			skillsPanel.SetActive(!isActive);

			//print("skill tree Button");
		}
	}
	public void skillLevelUp(int skillIndex)
	{
		abilityBases = GameObject.FindGameObjectWithTag("UI").GetComponents<Ability2>();
		if(skills[skillIndex] !=null)
		{
			playerSkillPoint = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSkillPoint>();
			if(playerSkillPoint.skillPoint >=1)
			{
			playerSkillPoint.skillPoint-=1;

			skills[skillIndex].SetActive(true);
			
			PlayerPrefs.SetInt ("skill"+skillIndex.ToString(), 1);

			//print(PlayerPrefs.SetInt ("skill"));
			//savedSkill2 = skills[skillIndex];

			//print(abilityBases.Length);
			
			//abilityBases[skillIndex].getSkill =1;
		
			}
		}
	}

	void Update () 
	{

	}
}
