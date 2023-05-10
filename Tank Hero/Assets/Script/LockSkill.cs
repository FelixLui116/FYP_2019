using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockSkill : AbilityBase {
//public class LockSkill : MonoBehaviour {
	//public AbilityBase abilityBase;    print(abilityBase.lockSkill);
	
	//This script is locking skill

	public bool unlockSkill2 = false;
	public bool unlockSkill3 = false;
	//public bool unlockSkill = false;

	// Use this for initialization
	void Start () {
		//PlayerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<playerShooting>();
		}
	
	// Update is called once per frame
	void Update () {
		//print(lockSkill);
	}

	public void unlockSkill_2()
	{
		//lockSkill = unlockSkill;
		unlockSkill2 = true;
	}

	
	public void unlockSkill_3()
	{
		//lockSkill = unlockSkill;
		unlockSkill3 = true;
	}
}
