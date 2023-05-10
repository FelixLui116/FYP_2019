using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillPoint : MonoBehaviour {

	// This script is about play and the skill point, the collider skill item (it is the testing item)
	public int skillPoint = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Skill")
		{
			Destroy(other.gameObject);
			print("Get Coin");
			skillPoint +=1;
		}
	}

}
