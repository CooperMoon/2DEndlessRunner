using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;

public class MainMenuManager : MonoBehaviour
{
    public void PlayButton()
    {
        Debug.Log("MainMenu PlayButton Pressed");
        EditorSceneManager.LoadScene("GameScene");
    }

    public void OptionsButton()
    {
        Debug.Log("MainMenu OptionsButton Pressed");
    }

    public void QuitButton()
    {
        Debug.Log("MainMenu QuitButton Pressed");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
}
