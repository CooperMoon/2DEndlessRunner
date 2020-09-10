using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptv2 : MonoBehaviour
{
    #region Variables
    public DeathMenu deathMenuScript;   // variable for calling a function in another script
    public static bool death;           // a true or false statement for the players death
    #endregion

    private void Start()
    {
        death = false; // makes sure the player doesnt start dead
    }


    /// <summary>
    /// if the player touches an object tagged with death the player will die
    /// </summary>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "death")
        {
            deathMenuScript.LaunchDeathMenu();
            Debug.Log("player has died");
            death = true;
        }
    }
}
