using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    private bool timerIsRunning = false;
    public Text timeDisplayText;
    private void Start()
    {
        timerIsRunning = true;
    }
    void Update()
    {
        if (timerIsRunning)
        {
            if (ImportantVariables.GameDuration > 0)
            {
                ImportantVariables.GameDuration -= Time.deltaTime;
                DisplayTime(ImportantVariables.GameDuration);
            }
            else
            {
                Debug.Log("Time has run out!");
                ImportantVariables.GameDuration = 0;
                DisplayTime(ImportantVariables.GameDuration);
                timerIsRunning = false;
                ImportantVariables.DidWinGame = false;
                SceneManager.LoadScene("EndScene");
            }
        }
    }

    private void DisplayTime(float remainingTime)
    {
        float minutes = Mathf.FloorToInt(remainingTime / 60);
        float seconds = Mathf.FloorToInt(remainingTime % 60);
        timeDisplayText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}

