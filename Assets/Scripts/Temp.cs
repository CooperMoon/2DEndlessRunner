using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Temp : MonoBehaviour
    {
    Vector3 lastPos = Vector3.zero;
    // Update is called once per frame
    void Update()
        {
        Vector3 difference = lastPos - transform.position;
        Debug.Log(difference);
        lastPos = transform.position;
        }
    }
