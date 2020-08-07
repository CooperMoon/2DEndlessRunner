using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplashScreen : MonoBehaviour
{
    public float disableTime = 4f; //sets disableTime at 4 seconds
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > disableTime)
            {
            this.gameObject.SetActive(false); //after 4 seconds disables splash screen
            Debug.Log(Time.time);
            }
    }
}
