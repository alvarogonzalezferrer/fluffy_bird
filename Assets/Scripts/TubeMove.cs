using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// move the tubes
// krono 2022
public class TubeMove : MonoBehaviour
{

    public float speed = 5; 

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y); 
    }
}
