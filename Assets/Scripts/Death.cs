using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject player;
    
    private Boolean death;

    private void Update()
    {
        if (death == true)
        {
#if UNITY_EDITOR
            //if player dies the editor will exit playmode / or open the death menu
            EditorApplication.ExitPlaymode(); //Replace with gameObject.GetComponent<MyScript>().MyFunction(); to use the death menu  
#endif
            SceneManager.LoadScene("GameScene");

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
