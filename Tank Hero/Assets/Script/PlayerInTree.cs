using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInTree : MonoBehaviour {

	public bool playerInTree;

	//This script is about the player can hide in the tree, the enemy AI need to check the  playerInTree = false;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//print(playerInTree);
	}
	
	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Tree")
		{
			playerInTree = true;
		}
	}

	void OnTriggerExit2D(Collider2D other)
    {
        playerInTree = false;
    }

}
