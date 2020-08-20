using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    #region Variable List
    public GameObject pauseMenu;
    public static bool isPaused;
    #endregion

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
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
        pauseMenu.SetActive(true);
        Time.timeScale = 0f;
        isPaused = true;
    }

    public void ResumeGame()
    {
        pauseMenu.SetActive(false);
        Time.timeScale = 1f;
        isPaused = false;
    }

    #region PauseMenu Button Scripts
    public void ContinueButton()
    {
        ResumeGame();
    }
    public void MainMenuButton()
    {
        Debug.Log("Options Button Pressed");
        Time.timeScale = 1f;
        SceneManager.LoadScene("MainMenu");
    }
    public void PauseQuitButton()
    {
        Debug.Log("Quit Button Pressed");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
    #endregion

}
