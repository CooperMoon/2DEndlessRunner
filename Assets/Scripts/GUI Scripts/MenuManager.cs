using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour
{
    public AudioMixer mixer;
    public Slider musicSlider;
    public Slider seSlider;

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
    public void SettingsButton()
    {
        Debug.Log("Settings Button Pressed");
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

    #region Settings Screen Scripts
    public void SettingsBackButton()
    {
        Debug.Log("Back Button Pressed");
    }

    public void VolumeSettingsButton()
    {
        Debug.Log("Volume Button Pressed");
    }
    #endregion

    #region Volume Screen Scripts
    public void VolumeBackButton()
    {
        Debug.Log("Back Button Pressed");
    }

    public void SetMusicVolume(float value)
    {
        mixer.SetFloat("MusicVol", value);
    }

    public void SetSEVolume(float value)
    {
        mixer.SetFloat("SEVol", value);
    }
    #endregion

    public void Start()
    {
        LoadPlayerPrefs();
    }

    public void LoadPlayerPrefs()
    {
        //load music slider
        float musicVol = PlayerPrefs.GetFloat("MusicVol");
        musicSlider.value = musicVol;
        mixer.SetFloat("MusicVol", musicVol);

        //save sound effects slider
        float seVol = PlayerPrefs.GetFloat("SEVol");
        seSlider.value = seVol;
        mixer.SetFloat("SEVol", seVol);

    }

    public void SavePlayerPrefs()
    {
        //save music slider
        float musicVol;
        if(mixer.GetFloat("MusicVol", out musicVol))
        {
            PlayerPrefs.SetFloat("MusicVol", musicVol);
        }
        //save sound effects slider
        float seVol;
        if (mixer.GetFloat("SEVol", out seVol))
        {
            PlayerPrefs.SetFloat("SEVol", seVol);
        }

        PlayerPrefs.Save();
    }

}
