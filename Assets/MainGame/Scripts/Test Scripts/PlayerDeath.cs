using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDeath : MonoBehaviour
    {
    /*
    This script is used to detect a collision and destroy player 
    when colliding with deadly object         
     */

    public GameObject player; //Sets the chosen gameobject as the player

    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D col) //detects a collision
        {
        Debug.Log("collision");   //sends a message to the console when a collision is detected


        Destroy(player); //destroys the player on collision

        }
    }
