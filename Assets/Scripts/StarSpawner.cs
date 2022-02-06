using System.Collections;
using System.Collections.Generic;
using UnityEngine;


// star prize spawner
// Alvaro 2022

public class StarSpawner : MonoBehaviour
{
    public float maxTime = 6;
    public float timer = 0;
    
    public GameObject star;
    public GameObject bird; 

    public float height=2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timer > Random.Range(maxTime, maxTime*2))  // time randomized
        {
            GameObject newStar = Instantiate(star);

            newStar.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);

            newStar.GetComponent<StarPrizeMoves>().bird = bird; // reference bird in scene

            Destroy(newStar, 15); // free memory after x time

            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
