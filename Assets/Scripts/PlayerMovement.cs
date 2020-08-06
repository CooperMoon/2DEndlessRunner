using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /*
     * rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
       defines the speed of the x axis and leaves y as 0 or null
       letting the character move right (if using -speed it will go left)

     * rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
       defines the height at which the character will jump and ignores x axis movement
       (-jumpHeight will make you go down)

        the Rididbody2D velocity allows to keep track of how we were moving before and while we are changing the movement
        gives a smoother control
    */

    private Rigidbody2D rb2d;

    //floats to change the speed and/or height
    public float speed;
    public float jumpHeight;

    //Stores each key in a string variable
    private string rightKey = "d";
    private string leftKey = "a";
    private string jumpKey = "space";

    // Start is called before the first frame update
    void Start()
    {
        //Defines rb2d as component Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void MoveRight()//Makes a function for moving right
        {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

    private void MoveLeft()//Makes a function for moving left
        {
        rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        }

    private void Jump()//Makes a function for jumping
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
        }
    private void Stop()//Makes a function for stopping the character
        {
        rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }


    // Update is called once per frame
    void Update()
    {
        //if key pressed true call function and move player as defined in function
        if (Input.GetKey(rightKey)) 
            {
            MoveRight();
            }

        if (Input.GetKey(leftKey))
            {
            MoveLeft();
            }
        if (Input.GetKeyDown(jumpKey))
            {
            Jump();
            }
        //if neither left or right is pressed stop player
        if (!Input.GetKey(rightKey) && !Input.GetKey(leftKey))   
            {
            Stop();
            }
        
    }
}
