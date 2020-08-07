using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
    {
    public GameObject ourGameObject;
    public float speed;
    public float jump;

    // Start is called before the first frame update
    void Start()
        {

        }

    // Update is called once per frame
    void Update()
        {
        if (Input.GetKey(KeyCode.W))
            {
            Vector3 gameObjectPosition = ourGameObject.transform.position;

            gameObjectPosition.z = gameObjectPosition.z + (speed * Time.deltaTime);

            ourGameObject.transform.position = gameObjectPosition;
            }

        if (Input.GetKey(KeyCode.S))
            {
            Vector3 gameObjectPosition = ourGameObject.transform.position;

            gameObjectPosition.z = gameObjectPosition.z - (speed * Time.deltaTime);

            ourGameObject.transform.position = gameObjectPosition;
            }

        if (Input.GetKey(KeyCode.D))
            {
            Vector3 gameObjectPosition = ourGameObject.transform.position;

            gameObjectPosition.x = gameObjectPosition.x + (speed * Time.deltaTime);

            ourGameObject.transform.position = gameObjectPosition;
            }

        if (Input.GetKey(KeyCode.A))
            {
            Vector3 gameObjectPosition = ourGameObject.transform.position;

            gameObjectPosition.x = gameObjectPosition.x - (speed * Time.deltaTime);

            ourGameObject.transform.position = gameObjectPosition;
            }
        if (Input.GetKeyDown("space"))
            {
            Vector3 gameObjectPosition = ourGameObject.transform.position;

            gameObjectPosition.y = gameObjectPosition.y + jump;

            ourGameObject.transform.position = gameObjectPosition;
            }


        }
    }