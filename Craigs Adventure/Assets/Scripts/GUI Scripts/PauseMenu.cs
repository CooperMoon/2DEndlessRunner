using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    #region Variable List
    //Makes a public GameObject variable called pauseMenu
    public GameObject pauseMenu;
    //Makes a public staic boolean variable called isPaused
    public static bool isPaused;
    public DeathScriptv2 deathScript;
    #endregion

    void Start()
    {
        //sets the game object attached to the variable pauseMenu inactive
        pauseMenu.SetActive(false);
    }

    void Update()
    {
        //if the player is alive and escape is pressed the game will pause.
        //this is to ensure that the player can't continue playing after dying
        if (DeathScriptv2.death == false && Input.GetKeyDown(KeyCode.Escape))
        {
            //If the variable "isPaused" is equal to true then the method ResumeGame() runs, if else the method PauseGame() runs
            if(isPaused)
            {
                ResumeGame();
            }
            else
            {
                PauseGame();
            }
        }
    }

    public void PauseGame()
    {
        //sets the gameobject attached to the variable pauseMenu active
        pauseMenu.SetActive(true);
        //sets UnityEngine time to 0
        Time.timeScale = 0f;
        //sets the variable isPaused to false
        isPaused = true;
    }

    public void ResumeGame()
    {
        //sets the gameobject attached to the variable pauseMenu to inactive
        pauseMenu.SetActive(false);
        //sets UnityEngine time to 1/normal
        Time.timeScale = 1f;
        //sets the variable isPaused to false
        isPaused = false;
    }

    #region PauseMenu Button Scripts
    public void ContinueButton()
    {
        //calls the method ResumeGame when assigned to a button and pressed when run.
        ResumeGame();
    }

    public void MainMenuButton()
    {
        Debug.Log("Options Button Pressed");
        //sets the UnityEngine time to 1
        Time.timeScale = 1f;
        //sets the gameobject attached to the variable (Pause Screen) to true
        isPaused = false;
        //loads the scene called MainMenu
        SceneManager.LoadScene("MainMenu");
    }
    public void PauseQuitButton()
    {
        Debug.Log("Quit Button Pressed");
        //if this method is run while in the Unity Editor, exit playmode. If else quit this application
#if UNITY_EDITOR
        //exits Unity's Playmode
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        //closes the application
        Application.Quit();
    }
    #endregion

}
