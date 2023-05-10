using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameMenu : MonoBehaviour {

	//This script is game menu panel to active the trophy and skilltree panel system

	public GameObject panel;

	public GameObject trophyPanel;
	public GameObject skillTreeButtonPanel;
	//public GameObject backMenu;

		void Start () {
/* 		trophyPanel = GameObject.FindGameObjectWithTag("TrophyPanel");
		skillTreeButtonPanel = GameObject.FindGameObjectWithTag("SkillTreeButtonPanel"); */
		}


	// Use this for initialization
	public void OpenMenu () {
		if(panel != null)
		{
//////////////////////////
//pause time
//////////////////////////
			if(Time.timeScale == 1)
			Time.timeScale = 0;
			else
			Time.timeScale = 1;
//////////////////////////////////////////
//////////////////////////////////////////
			bool isActive = panel.activeSelf;
			panel.SetActive(!isActive);
			trophyPanel.SetActive(false);
			skillTreeButtonPanel.SetActive(false);
			//print("menu");
		}
	}


	public void backToMain()
	{
		/* if(panel != null)
		{
		SceneManager.LoadScene("Menu");
		}
		panel.SetActive(false);*/
		if(Time.timeScale == 1)
		Time.timeScale = 0;
		else
		Time.timeScale = 1;
		SceneManager.LoadScene("Menu");
	}


}
