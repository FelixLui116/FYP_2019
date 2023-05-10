using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trophy2 : TrophyBase {

	// This script is save the trophy and active in the trophy panel

	public int getTrophy2 = 0;
	
	public void TrophyGet()
	{
	}

	void Start () 
	{

	}
	
	// Update is called once per frame
	void Update () 
	{
		if (getTrophy2 == 1)
		{
			trophyMenu.SetActive(true);
			print(getTrophy2);
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

			getTrophy2 =1;

			print(getTrophy2);
			}
		}
	}

}
