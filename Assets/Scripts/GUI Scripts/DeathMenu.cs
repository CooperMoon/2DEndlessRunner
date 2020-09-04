using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.UI;

public class DeathMenu : MonoBehaviour

{
    #region Variable List
    //Creates a public GameObject variable called deathScreen
    public GameObject deathScreen;
    #endregion

    public void Start()
    {
        //Sets the GameObject (Death Screen) attached to the variable deathScreen to false
        deathScreen.SetActive(false);
    }

    public void LaunchDeathMenu()
    {
        //sets the variable death in the class Death to false
        Death.death = false;
        Debug.Log("Death Menu Launched");
        //sets the variable showDisplay in the class Score to false (this sets the score canvas inactive)
        ScoreManager.showDisplay = false;
        //Sets UnityEngine time to 0
        Time.timeScale = 0f;
        //Sets the GameObject attached to the variable deathScreen to true
        deathScreen.SetActive(true);
    }

    public void MainMenuButton()
    {
        //Sets UnityEngine time to 1
        Time.timeScale = 1f;
        //Sets the GameObject attached to the variable deathScreen to false 
        deathScreen.SetActive(false);
        //sets the variable showDisplay in the class Score to false (this sets the score canvas active)
        ScoreManager.showDisplay = true;
        //Loads the scene called "MainMenu"
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        //If this method is run while in the Unity Editor, exit playmode. If else quit this application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
