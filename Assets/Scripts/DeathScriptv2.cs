using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathScriptv2 : MonoBehaviour
{
    #region Variables
    public DeathMenu deathMenuScript;
    public bool death;
    #endregion

    private void Start()
    {
        death = false;
    }

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
