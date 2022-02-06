using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// creates new tubes
// krono 2022

public class TubeSpawner : MonoBehaviour
{

    public GameObject getReadyCanvas; // get ready goes off with first tube!
 
    public float maxTime = 2;
    public float timer = 0;
    public GameObject tube;
    public float height;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > Random.Range(maxTime, maxTime * 3))  // time randomized
        {
            GameObject newTube = Instantiate(tube);

            newTube.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            Destroy(newTube, 15); // free memory after x time

            timer = 0;

            getReadyCanvas.SetActive(false); // after first tube, we remove "get ready" message
        }

        timer += Time.deltaTime;
    }
}
