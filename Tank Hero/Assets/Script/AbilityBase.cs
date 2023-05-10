using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AbilityBase : MonoBehaviour {
[SerializeField] protected Button skillButton;
[SerializeField] protected Button skillButton2;
//public int getSkill = 0;

//This is the skill base, can add the skill to inherit this script
public GameObject playerShield;

//public bool lockSkill =false;

public float delay;
public float coolDownTimer = 0;
protected bool activated;

	// Use this for initialization
	protected void Start () {
		activated = false;
	}
	
	// Update is called once per frame
	protected void Update () {
		if (activated)
		{
			coolDownTimer -=Time.deltaTime;
		}
		else
		{
			coolDownTimer = delay;
		}
				if(activated)
				{
					if(coolDownTimer > 3)
					{
						activateAbility();
					}
					else
					{
						deactivateAbility();
					}
				}
				else
				{
					deactivateAbility();
				}
			if(coolDownTimer < 0)
    		{
				activated = false;
        	}

	/* protected void Update () {
		if (activated)
		{
			coolDownTimer -=Time.deltaTime;

		}
		else
		{
			coolDownTimer = delay;
		}
				if(activated)
				{
					activateAbility();
				}
				else
				{
					deactivateAbility();
				}
			if(coolDownTimer <0)
    		{
				activated = false;
			
        	}
		*/

	}
	public virtual void activateAbility()
	{

	}
	public virtual void deactivateAbility()
	{

	}
}
