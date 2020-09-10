using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxbackground : MonoBehaviour
{
    private float length, startpos;     // variable for the start and length of the sprite
    public GameObject cam;              // variable for the camera
    public float parallaxEffect;        // variable for how much parallax we want

    
    void Start()
    {
        // determines the start position
        startpos = transform.position.x;
        // gets the length of the sprite
        length = GetComponent<SpriteRenderer>().bounds.size.x;
    }

    
    void FixedUpdate()
    {
        // used to move the sprite with the camera at the set parallax effect
        float temp = (cam.transform.position.x* (1 - parallaxEffect));
        float dist = (cam.transform.position.x * parallaxEffect);

        // moves the sprite
        transform.position = new Vector3(startpos + dist, transform.position.y, transform.position.z);

        // makes sure the sprite stays with the camera and to restart the parallax
        if (temp > startpos + length) startpos += length;
        else if (temp < startpos - length) startpos -= length;
    }
}
