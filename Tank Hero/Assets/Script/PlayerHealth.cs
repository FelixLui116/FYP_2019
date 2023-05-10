using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour {

    //This script is about the player HP, it set 10 if HP 0 it show the gameover panel

	public int health = 10;
    public GameObject GameOverPanel;
    private ProgressBar progressBar;
	void Start () {
        progressBar = GameObject.FindGameObjectWithTag("HealthBar").GetComponent<ProgressBar>();
	}
	
	// Update is called once per frame
	void Update () {
        progressBar.BarValue = health;
	}

    void OnTriggerEnter2D()
    {  
        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {	
         
        if(GameOverPanel != null)
		{
            //pause Time
			/* if(Time.timeScale == 1)
			Time.timeScale = 0;
			else
			Time.timeScale = 1;*/
            print("player die");
			//bool isActive = GameOverPanel.activeSelf;
			GameOverPanel.SetActive(true);
        }
    }
}
