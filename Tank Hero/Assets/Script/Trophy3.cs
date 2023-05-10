using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy3 : TrophyBase {

	// This script is save the trophy and active in the trophy panel

	public int getTrophy3 = 0;
	
	public void TrophyGet()
	{
	}

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (getTrophy3 == 1)
		{
			trophyMenu.SetActive(true);
			print(getTrophy3);
		}
	}

	public override void OnTriggerEnter2D(Collider2D other)
	{
		if (other.gameObject.tag == "Player")
		{
			Destroy(gameObject);
			print("Get Trophy");

			if (base.trophyMenu != null)
			{
			bool isActive = trophyMenu.activeSelf;

			trophyMenu.SetActive(!isActive);

			getTrophy3 =1;

			print(getTrophy3);
			}
		}
	}
}
