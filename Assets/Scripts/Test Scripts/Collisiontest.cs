using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collisiontest : MonoBehaviour
{
    public float count = 2;
    private void OnCollisionEnter2D(Collision2D col)
        {
            count = 0;//if collision detected count goes to 0 else stays at 2
            Debug.Log(count);
        }
}
