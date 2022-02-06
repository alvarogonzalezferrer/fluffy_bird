using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public static int score = 0;

    public Text scoreTxt;

    private void Start()
    {
        score = 0;
    }

    private void Update()
    {
        scoreTxt.text = "Score : " + score.ToString();
    }
}

