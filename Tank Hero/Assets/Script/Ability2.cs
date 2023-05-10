using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability2 : AbilityBase {
    private playerShooting PlayerShooting;


	private LockSkill unlockNewSkill;

	void Start () {
		PlayerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<playerShooting>();
		
		unlockNewSkill = GetComponent<LockSkill>();
	}
	
	
	void Update () {
		base.Update();
			//check unlock the skill 
			if(unlockNewSkill.unlockSkill2 == true)
			{
				//key press Q to use the skill 
				if (Input.GetKeyDown(KeyCode.Q))
        		{
					activated = true;
            		print("space key Q  was pressed");
        		}
			}
		//}
	}

	//The chabge the fire delay time to shoot faster
	public override void activateAbility()
	{					
            PlayerShooting.fireDelay =0.2f;
		    print("skill 2 used");
	}

	// set the default shooting speed 
	public override void deactivateAbility()
	{
		PlayerShooting.fireDelay =0.5f;
	}
}
