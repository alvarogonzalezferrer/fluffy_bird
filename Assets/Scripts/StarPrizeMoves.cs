using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Star prize 
// gives God mode for a few moments
// Alvaro "Krono" 2022
public class StarPrizeMoves : MonoBehaviour
{
    public float speed = 5;

   // public float duration = 13; // God mode duration --will last as sound music last

    public AudioSource starSnd;

    public GameObject bird; // need to set God mode, set by star spawner

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(transform.position.x - speed * Time.deltaTime * Random.Range(1.0f, +2.0f), transform.position.y + speed * Time.deltaTime * Random.Range(-2.0f, +2.0f));
    }

    // collides
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Debug.Log("Colision Estrella");

        if (!starSnd.isPlaying) // dont play twice if already has star effect
            starSnd.Play();

        transform.position = Vector3.one * 9999f; // move the game object off screen while it finishes it's sound, then destroy it
        Destroy(gameObject, starSnd.clip.length);

        bird.GetComponent<FlyBird>().starGodMode = starSnd.clip.length; // duration of mario music!

        // debug self remove -- will cut audio
        //Destroy(gameObject);
    }
}
