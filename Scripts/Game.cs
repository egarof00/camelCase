using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game : MonoBehaviour
{
    public List<GameObject> textBoxes;
    public GameObject characterCardsPage;
    public GameObject answerPage;

    private void Start()
    {
        ImportantVariables.NumOfGuesses = 3;
        ImportantVariables.GameDuration = 480f;
        foreach (GameObject textBox in textBoxes)
        {
            textBox.SetActive(false);
        }
        characterCardsPage.SetActive(false);
        answerPage.SetActive(false);
        BackgroundMusic.Instance.PlayBackgroundMusic();
    }
}
