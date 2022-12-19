using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class TopBarUI : MonoBehaviour
{
    public GameObject characterInfoPage;
    public GameObject answerPage;

    public bool isUIPageOpen = false;
    
    public void OnCharacterInfoButtonPress()
    {
        characterInfoPage.SetActive(true);
        isUIPageOpen = true;
    }

    public void OnCharacterBackButtonPress()
    {
        characterInfoPage.SetActive(false);
        isUIPageOpen = false;
    }
    
    public void OnAnswerButtonPress()
    {
        answerPage.SetActive(true);
        isUIPageOpen = true;
        BackgroundSounds.Instance.PlayClockTicking();
    }

    public void OnAnswerBackButtonPress()
    {
        answerPage.SetActive(false);
        isUIPageOpen = false;
        BackgroundSounds.Instance.StopAudio();
    }
}
