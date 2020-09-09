using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingsMenu : MonoBehaviour
{
    #region Variable List
    public Resolution[] resolutions;
    public Dropdown resolution;
    #endregion

    void Start()
    {
        // assigns resolution display information to the array resolutions
        resolutions = Screen.resolutions;
        resolution.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for(int i = 0; i < resolutions.Length; i++) //Go through every resolution
        {
            //Build a string for displaying the resolution
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);
            if(resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height)
            {
                //We have found the current screen resolution, save that number.
                currentResolutionIndex = i;
            }
        }
        //Set up our dropdown
        resolution.AddOptions(options);
        resolution.value = currentResolutionIndex;
        resolution.RefreshShownValue();
    }

    public void SetResolution(int resolutionindex)
    {
        Resolution res = resolutions[resolutionindex];
        Screen.SetResolution(res.width, res.height, false);
    }
}
