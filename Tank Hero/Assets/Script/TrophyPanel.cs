using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrophyPanel : MonoBehaviour {

	// This script is click trophypanal button will show the trophypanal

	public GameObject trophypanel;

	public void OpentrophypanelMenu () {
		if(trophypanel != null)
		{
			bool isActive = trophypanel.activeSelf;

			trophypanel.SetActive(!isActive);
			//print("trophypanel");
		}
	}
}
