using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HelpToMenu : MonoBehaviour {

	//This script is in the help scene and go back to the main menu
	void Start () {

	}
	
	public void BackToMenu () {
		/* if(BackButton == !null)
		{
        SceneManager.LoadScene("Menu");
		}*/
		SceneManager.LoadScene("Menu");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
