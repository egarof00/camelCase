using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndOfGame : MonoBehaviour
{
    public Image WinImage;
    public Image LoseImage;
    void Start()
    {
        if (ImportantVariables.DidWinGame)
        {
            LoseImage.gameObject.SetActive(false);
            WinImage.gameObject.SetActive(true);
        }
        else
        {
            LoseImage.gameObject.SetActive(true);
            WinImage.gameObject.SetActive(false);
        }
    }
}
