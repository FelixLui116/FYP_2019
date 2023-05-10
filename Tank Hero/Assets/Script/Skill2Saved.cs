using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill2Saved : AbilityBase {

	public GameObject Skill2;

	private LockSkill unlockNewSkill;

	// This script is about the load the skill to other scene and unlock the skill for the player

	void Start () {
		unlockNewSkill = GetComponent<LockSkill>();

		if(PlayerPrefs.GetInt("skill1")==1)
		{
			unlockNewSkill.unlockSkill_2();
			Skill2.SetActive(true);
			//print(PlayerPrefs.GetInt ("skill"+i.ToString()));
		}
		else
		{
			Skill2.SetActive(false);
		}
	}
	
	// Update is called once per frame
	void Update () {
	//print(PlayerPrefs.GetInt ("skill2"());
	}
}
