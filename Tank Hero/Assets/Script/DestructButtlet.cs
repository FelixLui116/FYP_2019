using UnityEngine;
using System.Collections;

public class DestructButtlet : MonoBehaviour {

	// Use this for initialization
	public float timer;

	void Update () {
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
		}
	}

/* 	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Wall")
		{
			Destroy(gameObject);
		}
	
	} */
}

