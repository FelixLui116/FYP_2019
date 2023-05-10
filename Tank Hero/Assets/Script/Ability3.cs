using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability3 : AbilityBase {

	private playerMovement PlayerMovement;

	private SkillTreeButton playerSkillTreeButton;

	//public int getSkill3 = 0;

	private LockSkill unlockNewSkill;

	// Use this for initialization
	void Start () {
		//PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
	//playerSkillTreeButton = GameObject.FindGameObjectWithTag("UI").GetComponent<SkillTreeButton>();
	
		unlockNewSkill = GetComponent<LockSkill>();
	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
		
		//if(lockSkill = unlockNewSkill.unlockSkill)
		
		// the skill key to use the skill
		if(unlockNewSkill.unlockSkill3 == true)
			{
			if (Input.GetKeyDown(KeyCode.R))
        	{
				activated = true;
            	print("space key Q  was pressed");
        	}
		}
	}

	// active the shield
	public override void activateAbility()
	{
				bool isActive = playerShield.activeSelf;
				playerShield.SetActive(true);
				print("SetActive(true)");

	}

	// not active the shield
	public override void deactivateAbility()
	{
		playerShield.SetActive(false);
	}
}
