using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkRoad : MonoBehaviour {

	public bool playerOnRoad;

	private playerMovement PlayerMovement;

	// This script is the player on the road can move faster.
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Road")
		{
			PlayerMovement = GetComponent<playerMovement>();
			PlayerMovement.defaultMoveSpeed =6;
			playerOnRoad = true;
			print(PlayerMovement.moveSpeed);
		}
	}
	void OnTriggerExit2D(Collider2D other)
	{
		if (other.gameObject.tag == "Road")
		{
			PlayerMovement.defaultMoveSpeed =3;        
			playerOnRoad = false;
			print(PlayerMovement.moveSpeed);
		}
	}

}
