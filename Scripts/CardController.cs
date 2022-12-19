using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardController : MonoBehaviour
{
    public Image SandyCard;
    public Image SimonCard;
    public Image RomeroCard;
    public Image MaryCard;
    public Image AltheaCard;
    public Image HandselCard;
    public Image DreCard;
    public Image AmitCard;

    public DialogueManager DialogueManager;

    private void Start()
    {
        SetAllCardsInactive();
    }

    private void Update()
    {
        if (DialogueManager.hasTalkedTalkedToSandy)
        {
            SetSandyCardActive();
        }
        if (DialogueManager.hasTalkedToSimon)
        {
            SetSimonCardActive();
        }
        if (DialogueManager.hasTalkedToRomero)
        {
            SetRomeroCardActive();
        }
        if (DialogueManager.hasTalkedToMary)
        {
            SetMaryCardActive();
        }
        if (DialogueManager.hasTalkedTalkedToAlthea)
        {
            SetAltheaCardActive();
        }
        if (DialogueManager.hasTalkedToHandsel)
        {
            SetHandselCardActive();
        }
        if (DialogueManager.hasTalkedToDre)
        {
            SetDreCardActive();
        }
        if (DialogueManager.hasTalkedToAmit)
        {
            SetAmitCardActive();
        }
    }

    public void SetSandyCardActive()
    {
        SandyCard.gameObject.SetActive(true);
    }

    public void SetSimonCardActive()
    {
        SimonCard.gameObject.SetActive(true);
    }
    
    public void SetRomeroCardActive()
    {
        RomeroCard.gameObject.SetActive(true);
    }
    
    public void SetMaryCardActive()
    {
        MaryCard.gameObject.SetActive(true);
    }
    
    public void SetAltheaCardActive()
    {
        AltheaCard.gameObject.SetActive(true);
    }
    
    public void SetHandselCardActive()
    {
        HandselCard.gameObject.SetActive(true);
    }
    
    public void SetDreCardActive()
    {
        DreCard.gameObject.SetActive(true);
    }
    
    public void SetAmitCardActive()
    {
        AmitCard.gameObject.SetActive(true);
    }

    public void SetAllCardsActive()
    {
        SetSandyCardActive();
        SetSimonCardActive();
        SetRomeroCardActive();
        SetMaryCardActive();
        SetAltheaCardActive();
        SetHandselCardActive();
        SetDreCardActive();
        SetAmitCardActive();
    }
    
    public void SetSandyCardInactive()
    {
        SandyCard.gameObject.SetActive(false);
    }

    public void SetSimonCardInactive()
    {
        SimonCard.gameObject.SetActive(false);
    }
    
    public void SetRomeroCardInactive()
    {
        RomeroCard.gameObject.SetActive(false);
    }
    
    public void SetMaryCardInactive()
    {
        MaryCard.gameObject.SetActive(false);
    }
    
    public void SetAltheaCardInactive()
    {
        AltheaCard.gameObject.SetActive(false);
    }
    
    public void SetHandselCardInactive()
    {
        HandselCard.gameObject.SetActive(false);
    }
    
    public void SetDreCardInactive()
    {
        DreCard.gameObject.SetActive(false);
    }
    
    public void SetAmitCardInactive()
    {
        AmitCard.gameObject.SetActive(false);
    }

    public void SetAllCardsInactive()
    {
        SetSandyCardInactive();
        SetSimonCardInactive();
        SetRomeroCardInactive();
        SetMaryCardInactive();
        SetAltheaCardInactive();
        SetHandselCardInactive();
        SetDreCardInactive();
        SetAmitCardInactive();
    }
    
}
