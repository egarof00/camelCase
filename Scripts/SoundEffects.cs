using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffects : MonoBehaviour
{
    private AudioSource audioSource;
    public AudioClip simonTalking;
    public static SoundEffects Instance;
    
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

    public void PlaySimonTalking()
    {
        audioSource.PlayOneShot(simonTalking);
    }
    

    public void StopAudio()
    {
        audioSource.Stop();
    }
}