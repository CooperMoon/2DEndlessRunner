using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllertest : MonoBehaviour
{

    private Rigidbody2D rb2d;

    //Stores Numbers that can be changed easily when needed
    private float speed = 15;
    private float jump = 12;
    
    //Will Store keys (up, down, left and right) to be called later
    private string right = "d"; 
    private string left = "a";
    private string up = "space";

    // Start is called before the first frame update
    void Start()
    {
        //declares rb2d as the component Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Right()
        {
        //Used to move the player along the x axis at a set 'speed' as well as keep the movement more realistic
        rb2d.velocity = new Vector2(speed, rb2d.velocity.y);
        }

    private void Left()
        {
        rb2d.velocity = new Vector2(-speed, rb2d.velocity.y);
        }

    private void Jump()
        {
        rb2d.velocity = new Vector2(rb2d.velocity.x, jump);
        }

    private void stop()
        {
        rb2d.velocity = new Vector2(0, rb2d.velocity.y);
        }

    // Update is called once per frame
    
    
    void Update()
    {
            if (Input.GetKey(right))
                {
                Right();
                }

            if (Input.GetKey(left))
                {
                Left();
                }
            if (!Input.GetKey(left) && !Input.GetKey(right))
                {
                stop();
                }

            if (Input.GetKeyDown(up))
                {
                Jump();
                }
           
        }
       
         

 }

