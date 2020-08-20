using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    #region Menu Screen Scripts
    public void PlayButton()
    {
        Debug.Log("Play Button Pressed");
        SceneManager.LoadScene("GameScene");
    }
    public void OptionsButton()
    {
        Debug.Log("Options Button Pressed");
    }
    public void MainMenuQuitButton()
    {
        Debug.Log("Quit Button Pressed");

#if UNITY_EDITOR
        UnityEditor.EditorApplication.ExitPlaymode();
#endif
        Application.Quit();
    }
    #endregion

    #region Options Screen Scripts
    public void ControlsButton()
    {
        Debug.Log("Controls Button Pressed");
    }
    public void VolumeButton()
    {
        Debug.Log("Volume Button Pressed");
    }
    public void OptionsBackButton()
    {
        Debug.Log("Back Button Pressed");
    }
    #endregion

    #region Controls Screen Scripts
    public void ControlsBackButton()
    {
        Debug.Log("Back Button Pressed");
    }
    #endregion

    #region Volume Screen Scripts
    public void VolumeBackButton()
    {
        Debug.Log("Back Button Pressed");
    }
    #endregion

}
