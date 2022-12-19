using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class DialogueManager : MonoBehaviour
{
    public Camel Camel;
    public bool isTalking;

    public bool hasTalkedTalkedToSandy = false;
    public bool hasTalkedToSimon = false;
    public bool hasTalkedToRomero = false;
    public bool hasTalkedToMary = false;
    public bool hasTalkedTalkedToAlthea = false;
    public bool hasTalkedToHandsel = false;
    public bool hasTalkedToDre = false;
    public bool hasTalkedToAmit = false;
    
    public GameObject SandyTextObjects;
    public GameObject SimonTextObjects;
    public GameObject RomeroTextObjects;
    public GameObject AltheaTextObjects;
    public GameObject MaryTextObjects;
    public GameObject HandselTextObjects;
    public GameObject DreTextObjects;
    public GameObject AmitTextObjects;
    
    private void Start()
    {
        isTalking = false;
    }
    
    public void OnDoneButtonClick()
    {
        SetCorrectCharacterTextBoxInactive(Camel.characterBeingCollidedWith);
        isTalking = false;
    }

    private void Update()
    {
        if (Camel.isHoveringOverCharacter && Input.GetKeyDown(KeyCode.Space))
        {
            isTalking = true;
            SetCorrectCharacterTextBoxActive(Camel.characterBeingCollidedWith);
        }
    }

    private void SetCorrectCharacterTextBoxActive(string characterName)
    {
        // FILL IN OTHER CHARACTERS
        switch (characterName)
        {
            case "Mary":
                MaryTextObjects.SetActive(true);
                hasTalkedToMary = true;
                break;
            case "Dre":
                DreTextObjects.SetActive(true);
                hasTalkedToDre = true;
                break;
            case "Sandy":
                SandyTextObjects.SetActive(true);
                hasTalkedTalkedToSandy = true;
                break;
            case "Handsel":
                HandselTextObjects.SetActive(true);
                hasTalkedToHandsel = true;
                break;
            case "Althea":
                AltheaTextObjects.SetActive(true);
                hasTalkedTalkedToAlthea = true;
                break;
            case "Romero":
                RomeroTextObjects.SetActive(true);
                hasTalkedToRomero = true;
                break;
            case "Simon":
                SoundEffects.Instance.PlaySimonTalking();
                SimonTextObjects.SetActive(true);
                hasTalkedToSimon = true;
                break;
            case "Amit":
                AmitTextObjects.SetActive(true);
                hasTalkedToAmit = true;
                break;
        }
    }
    

    public void SetCorrectCharacterTextBoxInactive(string characterName)
    {
        // FILL IN OTHER CHARACTERS
        switch (characterName)
        {
            case "Mary":
                MaryTextObjects.SetActive(false);
                break;
            case "Dre":
                DreTextObjects.SetActive(false);
                break;
            case "Sandy":
                SandyTextObjects.SetActive(false);
                break;
            case "Handsel":
                HandselTextObjects.SetActive(false);
                break;
            case "Althea":
                AltheaTextObjects.SetActive(false);
                break;
            case "Romero":
                RomeroTextObjects.SetActive(false);
                break;
            case "Simon":
                SoundEffects.Instance.StopAudio();
                SimonTextObjects.SetActive(false);
                break;
            case "Amit":
                AmitTextObjects.SetActive(false);
                break;
        }
    }
    
}
