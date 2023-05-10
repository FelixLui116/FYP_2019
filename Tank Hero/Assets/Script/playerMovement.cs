using UnityEngine;
using System.Collections;

public class playerMovement : MonoBehaviour {

// This script is about the palyer movespeed

public float defaultMoveSpeed;
	private float movex;
	private float movey;
	//Ability1 
	public float moveSpeed = 5;
	// Update is called nce per frame
	void FixedUpdate () {
		movex = Input.GetAxis ("Horizontal");
		movey = Input.GetAxis ("Vertical");

		GetComponent<Rigidbody2D> ().velocity = new Vector2 (movex * moveSpeed, movey * moveSpeed);
		//print (moveSpeed);
	}
}
