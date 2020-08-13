using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{

    public GameObject pauseMenu;

    //Makes a public static bool called isPaused
    //Make sure to use this variable to define whether the game is paused in GameScene Scripts
    public static bool isPaused;

    // Start is called before the first frame update
    void Start()
    {
        //Sets the gameobject attached to the variable pauseMenu inActive
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //If the key ESCAPE is pressed and isPaused = false this runs the method PauseMenu()
        if(Input.GetKeyDown(KeyCode.Escape) && isPaused == false)
        {
            PauseGame();
        }
    }

    public void PauseGame()
    {
        pauseMenu.SetActive(true); //pauseMenu.SetActive(true); sets the gameobject attached to pauseMenu active
        Time.timeScale = 0f; //Makes the scale at which time passes in a game to 0, this stops Unity from updating the gamescene
        isPaused = true; //Sets the variable isPaused to true
    }

    public void ResumeGameButton()
    {
        pauseMenu.SetActive(false); //pauseMenu.SetActive(true); sets the gameobject attached to pauseMenu inActive
        Time.timeScale = 1f; //Makes the scale at which time passes in game to 1, this setting Unity to it's default time scale
        isPaused = false; //Sets the variable isPaused to false
    }

    public void MainMenuButton()
    {
        Time.timeScale = 1f; //Makes the scale at which time passes in game to 1, this setting Unity to it's default time scale
        SceneManager.LoadScene("MainMenuScene"); //Loads the scene "MainMenuScene"
    }
}
