using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SkillAbility : MonoBehaviour {


    public Button skillSpeedUpButton;
    public Button skillSpeedUp2Button;
    public Button skillShootSpeedUp;

    public float skill1Delay = 5.0f;
    public float coolDownTimer = 0;

    public float shootingSkillDelay = 3.0f;
    public float shootingCoolDownTimer = 0;

    public float speedUpLv2Delay = 10.0f;
    public float speedUpLv2CoolDownTimer = 0;

    public GameObject shield;

	private playerMovement PlayerMovement;
    private playerShooting PlayerShooting;
    
	//private float speedUp;

    public void Start()
    {
        
        skillSpeedUpButton = skillSpeedUpButton.GetComponent<Button>();

        //PlayerMovement = GameObject.FindGameObjectWithTag("Player").GetComponent<playerMovement>();
		//PlayerShooting = GameObject.FindGameObjectWithTag("Player").GetComponent<playerShooting>();
        
        //skill2Button = skill2Button.GetComponent<Button>();
    }

    void Update() {
        coolDownTimer -= Time.deltaTime;
        shootingCoolDownTimer-= Time.deltaTime;
        speedUpLv2CoolDownTimer-= Time.deltaTime;

    }
 /* 
        if(coolDownTimer <= 0 || speedUpLv2CoolDownTimer <=0)
        {
            // reset the skill cooldown
            PlayerMovement.moveSpeed =3;
        }
 */
        /* 
        if(coolDownTimer <= 0 )
        {
            // reset the skill cooldown
            PlayerMovement.moveSpeed =3;
        }*/
/* 
        if(shootingCoolDownTimer <=0)
        {
            PlayerShooting.fireDelay =0.5f;
        }
    // Use this for initialization
    public void skillSpeedUp () {
        if(coolDownTimer <= -5)
        {
            if(coolDownTimer <= 0)
            {  
            coolDownTimer = skill1Delay;
            PlayerMovement.moveSpeed =10;

		    print("skill used");
            }
        }
	}

    public void speedUpLv2()
    {
            if(speedUpLv2CoolDownTimer <= -10)
            {
                if(speedUpLv2CoolDownTimer <= 0)
                {          
                speedUpLv2CoolDownTimer = speedUpLv2Delay;
                PlayerMovement.moveSpeed =10;
                print("skillUpSpeed used");

                bool isActive = shield.activeSelf;
			    shield.SetActive(isActive);
                print("shield isActive");
            }
        }
    }

    public void ShootSpeedUp () {
		print("skill2 used");
        if(shootingCoolDownTimer <= -7)
        {
            if(shootingCoolDownTimer <= 0)
            {  
            shootingCoolDownTimer = shootingSkillDelay;
            PlayerShooting.fireDelay =0.1f;
		    
            }
        }
    }
*/


}
