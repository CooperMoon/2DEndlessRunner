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

    private void MoveRight()
        {
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

    private void MoveLeft()
        {
        rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        }

    private void Jump()
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jumpHeight);
        }


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(rightKey))
            {
            MoveRight();
            }

        if (Input.GetKey(leftKey))
            {
            MoveLeft();
            }
        if (Input.GetKey(jumpKey))
            {
            Jump();
            }
    }
}
