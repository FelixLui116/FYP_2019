using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barricade : MonoBehaviour {

	//public GameObject DestroyBarricade;

	private DamageHandler damageHandler;

	// Use this for initialization
	void Start () {
		damageHandler = GameObject.FindGameObjectWithTag("Enemy").GetComponent<DamageHandler>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {

		if (other.gameObject.tag == "Enemy")
		{
			FloatTextEnemy floatTextEnemy = other.gameObject.GetComponent<FloatTextEnemy>();
			floatTextEnemy.SpawnText ();

			damageHandler.health -=1;
			Destroy(gameObject);
		}
	}
}
