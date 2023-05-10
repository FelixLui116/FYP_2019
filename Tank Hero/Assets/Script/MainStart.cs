using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainStart : MonoBehaviour {

    //This script is about the main menu change scene

    public Button startButton;
    public Button HelpButton;
    
    public Button exitButton;


    public void Start()
    {
        startButton = startButton.GetComponent<Button>();
        //HelpButton = HelpButton.GetComponent<Button>();
        exitButton = exitButton.GetComponent<Button>();
    }


    // Use this for initialization
    public void StartLevel () {
        SceneManager.LoadScene("Game");
        //PlayerPrefs.DeleteAll ();
	}

    public void HelpScene () {
        SceneManager.LoadScene("Help");
	}

    public void ExitGame()
    {

        Application.Quit();
    }
}

//public void StartLevel()
//{
//    SceneManager.LoadScene("Level01");
//}

//public void ExitGame()
//{
//    Application.Quit();
//}





//    using UnityEngine;
//using UnityEngine.UI;
//using UnityEngine.SceneManagement;
//using System.Collections;

//public class MenuScript : MonoBehaviour
//{

//    public Canvas quitMenu;
//    public Button startButton;
//    public Button settingsButton;
//    public Button exitButton;

//    // Use this for initialization
//    void Start()
//    {
//        quitMenu = quitMenu.GetComponent<Canvas>();
//        startButton = startButton.GetComponent<Button>();
//        settingsButton = settingsButton.GetComponent<Button>();
//        exitButton = exitButton.GetComponent<Button>();

//        //On Start make the quit menu inaccessible
//        quitMenu.enabled = false;
//    }

//    public void ExitPress()
//    {
//        //When exit is pressed, enable the menu and change settings
//        quitMenu.enabled = true;
//        startButton.enabled = false;
//        settingsButton.enabled = false;
//        exitButton.enabled = false;
//    }

//    public void NoPressed()
//    {
//        //when no is pressed, change the setttings
//        quitMenu.enabled = false;
//        startButton.enabled = true;
//        settingsButton.enabled = true;
//        exitButton.enabled = true;
//    }

//    public void StartLevel()
//    {
//        SceneManager.LoadScene("Main");
//    }

//    public void ExitGame()
//    {
//        Application.Quit();
//    }
//}