using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skill3Saved : AbilityBase {

	public GameObject Skill3;

	private LockSkill unlockNewSkill;

	// Use this for initialization
	void Start () {
		unlockNewSkill = GetComponent<LockSkill>();

		if(PlayerPrefs.GetInt("skill0")==1)
		{
			unlockNewSkill.unlockSkill_3();
			Skill3.SetActive(true);
			//print(PlayerPrefs.GetInt ("skill"+i.ToString()));
		}
		else
		{
			Skill3.SetActive(false);
		}
	}
	// Update is called once per frame
	void Update () {
		
	}
}
