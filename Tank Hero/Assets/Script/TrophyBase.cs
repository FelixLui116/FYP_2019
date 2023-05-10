using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TrophyBase : MonoBehaviour {

	[SerializeField] protected GameObject trophy;
	[SerializeField] protected GameObject trophyMenu;

	public virtual void OnTriggerEnter2D(Collider2D other)
	{

	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		/* if (getTrophy1 == 1)
		{
			trophyMenu.SetActive(true);
			print(getTrophy1);
		}

		if (getTrophy2 == 1)
		{
			trophyMenu.SetActive(true);
			print(getTrophy2);
		}

		if (getTrophy3 == 1)
		{
			trophyMenu.SetActive(true);
			print(getTrophy3);
		}
*/
	}
}
