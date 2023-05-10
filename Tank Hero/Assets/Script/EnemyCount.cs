using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCount : MonoBehaviour {

public int enemyKilled = 0;
public int endLevel;
public GameObject RedBlock;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(enemyKilled >= endLevel)
		{
			RedBlock.SetActive(false);
		}
	}
}
