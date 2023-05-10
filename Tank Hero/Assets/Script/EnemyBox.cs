using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBox : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "bulletEnemy")
		{
			Destroy(gameObject);
		}
	}

	/*  void OnTriggerExit2D(Collider2D other)
    {
       
    }*/
}
