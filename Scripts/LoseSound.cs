using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseSound : MonoBehaviour
{
    private AudioSource loseAudioSource;
    // Start is called before the first frame update
    void Start()
    {
        loseAudioSource = gameObject.GetComponent<AudioSource>();
        if (!ImportantVariables.DidWinGame)
        {
            loseAudioSource.Play();
        }
    }
}
