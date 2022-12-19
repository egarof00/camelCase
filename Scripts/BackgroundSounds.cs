using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundSounds : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip clockTicking;
    public static BackgroundSounds Instance;
    
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

    public void PlayClockTicking()
    {
        audioSource.PlayOneShot(clockTicking);
    }

    public void StopAudio()
    {
        audioSource.Stop();
    }
}