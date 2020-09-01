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

    // Start is called before the first frame update
    void Start()
    {
        //sets the game object attached to the game object pauseMenu to inactive
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //if the player is alive and escape is pressed the game will pause
        //this is too ensure that the player cant continue playing after dying
        if (deathScript.death == false && Input.GetKeyDown(KeyCode.Escape))
        {
            //If the variable is paused is true then the method ResumeGame() runs, if not the the method PauseGame() runs
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
        //Sets the gameobject attached to the variable pauseMenu to active
        pauseMenu.SetActive(true);
        //Sets UnityEngine time to 0
        Time.timeScale = 0f;
        //Sets the variable isPaused to false
        isPaused = true;
    }

    public void ResumeGame()
    {
        //Sets the gameobject attached to the variable pauseMenu to inactive
        pauseMenu.SetActive(false);
        //Sets UnityEngine time to 1/normal
        Time.timeScale = 1f;
        //Sets the variable isPaused to false
        isPaused = false;
    }

    #region PauseMenu Button Scripts
    public void ContinueButton()
    {
        //Calls the method ResumeGame
        ResumeGame();
    }

    public void MainMenuButton()
    {
        Debug.Log("Options Button Pressed");
        //Sets the UnityEngine time to 1/normal
        Time.timeScale = 1f;
        //Sets the gameobject attached to the variable pauseMenu to true
        isPaused = false;
        //Loads the scene called MainMenu
        SceneManager.LoadScene("MainMenu");
    }
    public void PauseQuitButton()
    {
        Debug.Log("Quit Button Pressed");

#if UNITY_EDITOR
        //Exits Unity's Playmode
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        //Closes the application
        Application.Quit();
    }
    #endregion

}
