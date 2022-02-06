using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

// game manager
// handles start, and game over cycles
// krono 2022

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject getReadyCanvas;
   

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        getReadyCanvas.SetActive(false);

        Time.timeScale = 0;
    }

    private void GameStart()
    {
        gameOverCanvas.SetActive(false);
        getReadyCanvas.SetActive(true);

        Time.timeScale = 1;
    }

    //restart game
    public void Replay()
    {
        SceneManager.LoadScene(0);

        GameStart();
    }

    // toggle sound
    public void ToggleSound()
    {
        AudioListener.pause = !AudioListener.pause;
    }

    // exit gme
    public void ExitGame()
    {
        Application.Quit();
    }
}
