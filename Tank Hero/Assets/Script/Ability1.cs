using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ability1 : AbilityBase {
	private playerMovement PlayerMovement;


	//this is the Ability 1 skill
	//The skill can change the speed of the player tank.
	void Start () 
	{
		// set the default Move Speed 
		PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
		PlayerMovement.defaultMoveSpeed = 3;
	}
	
	// Update is called once per frame
	void Update () {
		base.Update();
			// Key press E can activate the skill
			if (Input.GetKeyDown(KeyCode.E))
        	{
				activated = true;
            	print("space key E  was pressed");
        	}
	}
	// This is the skill speed
	public override void activateAbility()
	{
			PlayerMovement.moveSpeed =10;
	}
	
	// after using skill change to the defaultMoveSpeed
	public override void deactivateAbility()
	{
			PlayerMovement.moveSpeed =PlayerMovement.defaultMoveSpeed;
			
	}
}
