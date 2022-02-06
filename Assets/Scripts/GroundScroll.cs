using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// ground scrollin infinite
// krono 2022

public class GroundScroll : MonoBehaviour
{
    public float velocity = 5;
   
    private float length, startpos;

    float rightSideOfScreen;

    void Start()
    {
        startpos = transform.position.x;
        length = GetComponent<SpriteRenderer>().bounds.size.x; // size in units

        //For anyone looking at this now, this will produce something very close to the orthographic camera, but not exactly.To be exact you must use the aspect ratio of the camera
        // float height = Camera.main.orthographicSize * 2.0f;
        // float width = height * Camera.main.aspect;


        // right side screen
        rightSideOfScreen = 2.0f * Camera.main.orthographicSize * Camera.main.aspect;

    }

    
    void Update()
    {
        // check out of screen
        //transform.Translate(velocity * Time.deltaTime, 0, 0);
        transform.position = new Vector2(transform.position.x - velocity * Time.deltaTime, transform.position.y);

        if (transform.position.x + length < rightSideOfScreen + length/2)
            transform.position = new Vector2(startpos, transform.position.y);
    }

}
