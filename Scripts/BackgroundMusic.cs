using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMusic : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip backgroundMusic;
    public static BackgroundMusic Instance;
    
    private void Awake()
    {
        if (Instance != null && Instance != this)
            Destroy(this.gameObject);
        else
            Instance = this;
    }
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void PlayBackgroundMusic()
    {
        audioSource.PlayOneShot(backgroundMusic);
    }

    public void StopAudio()
    {
        audioSource.Stop();
    }
}