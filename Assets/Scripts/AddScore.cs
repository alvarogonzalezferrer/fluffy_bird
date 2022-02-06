using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddScore : MonoBehaviour
{
    public AudioSource scoreSnd;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Score.score++;
        scoreSnd.Play();
    }
}
