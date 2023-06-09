﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class FollowMouse : MonoBehaviour {
	public float offset = 0.0f;

	
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
		difference.Normalize();
		float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + offset);
	}
}
