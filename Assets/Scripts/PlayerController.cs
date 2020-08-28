using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    
    private Rigidbody2D rb2d;           //creates a variable rb2d of type Rigidbody2D

    public AudioSource jumpEffect;      //Testing
    

    #region movement variables
    public float playerSpeed;           //variable for inspector reference for the players speed
    public float jumpHeight;            //float for the players jump height
    public float count = 0;             //float for the jump count
    #endregion

    #region Start
    void Start()
    {   
        rb2d = GetComponent<Rigidbody2D>();
        jumpEffect = GetComponent<AudioSource>();
    }
    #endregion

    #region Update Methods
    void FixedUpdate()
    {
        // calls the run method to move the player
        // using the fixed frame rate method ensures the player moves at a constant rate
        // PlayerRun moves the player right.

        //if the variable isPaused in the PauseMenu script is false then the function PlayerRun() is called
        if (!PauseMenu.isPaused)
        {
            PlayerRun();
        }
    }

    private void Update()
    {
        // calls the jump method 
        // use update to catch a jump occurance at any time sp we do not miss any.

        //if the variable isPaused in the PauseMenu script is false then the function Jump() is called
        if (!PauseMenu.isPaused)
        {
            Jump();
        }
    }
    #endregion

    #region Movement methods
    private void PlayerRun()
    {
        //Makes the player move right on the X axis
        rb2d.velocity = new Vector2(playerSpeed * Time.deltaTime, rb2d.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyBindScript.keys["Jump"]) && count < 1)//checks if space has been pressed and count is less then 1
        {
            //if true jump and increase count
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
            count++;
            jumpEffect.Play();         
        }
    }
    #endregion

    #region collision detection
    private void OnTriggerStay2D(Collider2D collision)
    {
        count = 0;//if collider is touching another collider or rigidbody count goes to 0
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        // prevent jumping when not on a platform, e.g. fallen off.
        count = 1;//if collider is not touching another collider or rigidbody count goes to 1     
    }
    #endregion
}
