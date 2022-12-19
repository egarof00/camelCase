using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinSound : MonoBehaviour
{
    private AudioSource winAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        winAudioSource = gameObject.GetComponent<AudioSource>();
        if (ImportantVariables.DidWinGame)
        {
            winAudioSource.Play();
        }
    }
    
}
