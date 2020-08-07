using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    /*Creates buttons with code 

    *public void OnGUI() 
       {
       GUI.Box(new Rect(10, 10, 100, 90), "box");

       if (GUI.Button(new Rect(20, 40, 80, 20), "BUTTON"))
           {
           Debug.Log("OUCH!! dont press so hard ;-;");

           disable.SetActive(false); used to hide the menu when pressing options
           count++; counts how many times button is pressed
           }
       else if (count > 1) if button pressed twice show menu
           {
           disable.SetActive(true);
           count = 0;
           }

       if (GUI.Button(new Rect(850, 450, 100, 50), "Quit"))
       {
           Debug.Log("OUCH!! dont press so hard ;-;");

           QuitGame();
       }*/

    public string loadScene = "GameScene";

    public GameObject disable;
    //int count = 0;

    // Start is called before the first frame update
    void Start()
    {
     

    }
    public void StartGame()
        {
        SceneManager.LoadScene(loadScene);
        }

    public void QuitGame()
        {
        Debug.Log("Quitting Game");


#if UNITY_EDITOR

        EditorApplication.ExitPlaymode();   //exits out of playmode in unity

#endif
        
        Application.Quit(); // < - - this will close the game application 

        }



    }
