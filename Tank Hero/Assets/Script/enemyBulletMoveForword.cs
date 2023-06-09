﻿using UnityEngine;
using System.Collections;

public class enemyBulletMoveForword : MonoBehaviour {

	public float maxSpeed;

	// / This script is the enemy bullet move and collider player will destroy
	void Update () {
		Vector3 pos = transform.position;

		Vector3 velocity = new Vector3(0, maxSpeed * Time.deltaTime, 0);

		pos += transform.rotation * velocity;

		transform.position = pos;
	}

	void OnTriggerEnter2D(Collider2D other) 
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
		}
	}
}
