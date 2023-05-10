using UnityEngine;
using System.Collections;

public class DestructEnemyButtlet : MonoBehaviour {

	// This script is the enemy bullet collider wall and box
	public float timer;

	void Update () {
		timer -= Time.deltaTime;

		if(timer <= 0) {
			Destroy(gameObject);
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Wall")
		{
			Destroy(gameObject);
		}

		if (other.gameObject.tag == "Box")
		{
			Destroy(gameObject);
		}
	}
}