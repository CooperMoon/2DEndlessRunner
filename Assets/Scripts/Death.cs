using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    #region Variable List
    public GameObject player;
    
    public static bool death;

    //Makes a variable for the Class DeathMenu called deathMenuScript
    public DeathMenu deathMenuScript;
    #endregion

    private void Update()
    {
        if (death == true)
        {
            //Calls the method called LaunchDeathMenu from the class DeathMenu
            deathMenuScript.LaunchDeathMenu();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision) //for is trigger collision
    {
        //detects if the player has triggered a collision and then sets death to true else stays false
        death = true;
    }

    private void OnCollisionEnter2D(Collision2D collision) // for normal colision
    {
        //detects if the player has made a collision and then sets death to true else stays false
        death = true;
    }

}