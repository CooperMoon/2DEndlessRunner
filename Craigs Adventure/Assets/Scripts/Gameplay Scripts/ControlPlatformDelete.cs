using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlatformDelete : MonoBehaviour
{
    public float timer = 0.0f;
    public float startTime = 20.0f;
    
    void Start()
    {
        // Starts the timer on game start
        timer = startTime;    
    }

    
    void Update()
    {
        // Runs the timer and checks if it is less than or equal to 0
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            // if true it will destroy the gameObject it is attached too
            Destroy(this.gameObject);
        }
    }
}
