using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private bool isFalling = true;
    private float speed = 0.46f;
    private void OnTriggerEnter(Collider other)
    {
        isFalling = false;
    }



    // Update is called once per frame
    void Update()
    {
        Vector2 cubePosition = transform.position;
        if (isFalling == true)
        {
            if (Input.GetKeyDown("left"))
                {
                cubePosition.x -= speed;
                Debug.Log("Left.");
                }
            if (Input.GetKeyDown("right"))
            {
                cubePosition.x += speed;
                Debug.Log("Right.");
            }
        }
        transform.position = cubePosition;

      
    }

    
}
