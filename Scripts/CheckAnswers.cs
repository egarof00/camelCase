using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CheckAnswers : MonoBehaviour
{
    private string userInput = "";

    public Text guessesLeftText;
    public Text randomMessageText;

    private void Update()
    {
        ShowCorrectGuessMessage(ImportantVariables.NumOfGuesses);
    }

    public void GetInput(string userText)
    {
        userInput = userText.ToLower();
    }

    private bool CheckIfAnswerIsCorrect()
    {
        if (userInput == ImportantVariables.CorrectAnswer)
            return true;
        return false;
    }

    private bool doNumOfGuessesEqualZero()
    {
        if (ImportantVariables.NumOfGuesses == 0)
            return true;
        return false;
    }

    public void OnSubmitButtonClick()
    {
        if (CheckIfAnswerIsCorrect())
        {
            ImportantVariables.DidWinGame = true;
            SceneManager.LoadScene("EndScene");
        }
        else
        {
            ImportantVariables.NumOfGuesses--;
            if (doNumOfGuessesEqualZero())
            {
                ImportantVariables.DidWinGame = false;
                SceneManager.LoadScene("EndScene");
            }
        }
    }

    private void ShowCorrectGuessMessage(int guessesLeft)
    {
        switch (guessesLeft)
        {
            case 3:
                randomMessageText.text = "";
                guessesLeftText.text = "Guesses: " + ImportantVariables.NumOfGuesses;
                break;
            case 2:
                randomMessageText.text = "WRONG. Try again.";
                guessesLeftText.text = "Guesses: " + ImportantVariables.NumOfGuesses;
                break;
            case 1:
                randomMessageText.text = "Only one more chance! You've got to try harder than that";
                guessesLeftText.text = "Guesses: " + ImportantVariables.NumOfGuesses;
                break;
        }

    }
}
