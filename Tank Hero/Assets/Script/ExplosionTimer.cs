using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionTimer : MonoBehaviour {

	//This script is the how long explosion
	public float Timer = 1;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		Timer -= Time.deltaTime;
		if(Timer < 0)
		{
			Destroy(gameObject);
		}
	}


}
