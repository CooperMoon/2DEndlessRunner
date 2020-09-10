using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    
    private Rigidbody2D rb2d;           //creates a variable rb2d of type Rigidbody2D

    public AudioSource jumpEffect;      //Testing
    

    #region movement variables
    [Header("PlayerMovement")]
    [Tooltip("Used to adjust and change the players speed")]
    public float playerSpeed;           //variable for inspector reference for the players speed
    [SerializeField, Tooltip("Used o adjust and change the players Jumping height")]
    private float jumpHeight;           //float for the players jump height
    private float x = 600;              // variable to set the speed to 600 on start
   
    private float count = 0;             //float for the jump count
    #endregion

    #region Start
    void Start()
    {   
        rb2d = GetComponent<Rigidbody2D>();       // attaches the reference of rigidbody2D to the variable rb2d
        jumpEffect = GetComponent<AudioSource>(); // attaches the reference of audioSource to the variable JumpEffect
        playerSpeed = x;
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
        // use update to catch a jump occurance at any time so we do not miss any.

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
        // keeps the player moving at a constant speed on the x axis going right
        rb2d.velocity = new Vector2(playerSpeed * Time.deltaTime, rb2d.velocity.y);
    }

    private void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && count < 1)//checks if space has been pressed and count is less then 1
        {
            //if true jump and increase count
            rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
            count++;
            jumpEffect.Play();         
        }
    }
    #endregion

    #region collision detection

       // this is used as a basic ground check
       private void OnTriggerStay2D(Collider2D collision)
    {
        // if the player lands on the platform count is reset
        count = 0;
        Debug.Log("Can Jump");
    }

    // this will check if the player falls off a platform or has jumped
    private void OnCollisionExit2D(Collision2D collision)
    {
        // if the player has jumped or falled off the platform increase count
        count++;
        Debug.Log("Can't Jump");
    }   
    #endregion
}
