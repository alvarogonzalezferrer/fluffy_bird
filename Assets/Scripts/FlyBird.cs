using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Make the bird fly
// Krono 2022
public class FlyBird : MonoBehaviour
{
    public GameManager gameManager;
    public float velocity = 8; // jump speed
    public AudioSource crashSnd;// crash sound

    public AudioSource musicBKG;// music sound

    public float starGodMode=0; // duration of star God mode

    private Rigidbody2D rb; // the bird body
    private bool god = false; // cheat God mode 
    private int angle = 0; // rotate fly animation

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // quit game - DEBUG , move to game manager! 
        if (Input.GetKeyDown(KeyCode.Q) || Input.GetKeyDown(KeyCode.Escape))
            Application.Quit();

        // cheat, God Mode / G key
        if (Input.GetKeyDown(KeyCode.G))
            god = !god;

        // jump!
        if (Input.GetMouseButtonDown(0))
        {
            // fly
            rb.velocity = Vector2.up * velocity;

            // rotation down of sprite when jump up
            if (angle < 50)
            {
                rb.transform.Rotate(0, 0, 45);
                angle += 45;
            }
        }

        // stabilyze bird angle
        if (angle > 0)
        {
            angle--;
            rb.transform.Rotate(0, 0, -1);
        }

        if (starGodMode > 0)
        {
            // pause background music, mario theme is playing!
            musicBKG.Pause();

            // make color effect 
            SpriteRenderer m_SpriteRenderer;
            

            m_SpriteRenderer = GetComponent<SpriteRenderer>();

            // red for special effect
            m_SpriteRenderer.color = Color.red;

            starGodMode -= Time.deltaTime; // discount god mode star

            // finish effect?
            if (starGodMode < 1)
            {
                m_SpriteRenderer.color = Color.white; // normal color

                if (!musicBKG.isPlaying)
                {
                    musicBKG.Play(); // resume normal music
                }
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        crashSnd.Play();

        if (!god && !(starGodMode > 0)) // cheat or STAR? dont die if cheat on
        {
            gameManager.GameOver();
        }
    }
}
