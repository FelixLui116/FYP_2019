using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
	private MouseCorsor mouse;
	// Use this for initialization

	//this script is the change the crosshair 

	void Start () {
		mouse = GameObject.FindGameObjectWithTag("Mouse").GetComponent<MouseCorsor>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnMouseEnter()
	{
		mouse.changeMouseCursor();

	}

	void OnMouseExit()
	{
		mouse.defaultMouseCursor();
	}
}
