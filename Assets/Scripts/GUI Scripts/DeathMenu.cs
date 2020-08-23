using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using System;

public class DeathMenu : MonoBehaviour

{
    #region Variable List
    //Creates a public GameObject variable called deathScreen
    public GameObject deathScreen;
    #endregion

    public void Start()
    {
        //Sets the GameObject attached to the variable deathScreen to false
        deathScreen.SetActive(false);
    }

    public void LaunchDeathMenu()
    {
        Death.death = false;
        Debug.Log("Death Menu Launched");
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
        //Loads the Scene called MainMenu
        SceneManager.LoadScene("MainMenu");
    }

    public void QuitButton()
    {
        //If in the Unity Editor exit playmode, if not quit application
#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
