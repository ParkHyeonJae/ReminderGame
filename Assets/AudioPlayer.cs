using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip audioClip;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        PlaySound(audioClip, audioSource);
    }

    public static void PlaySound(AudioClip audioClip, AudioSource audioSource)
    {
        audioSource.clip = audioClip;
        
        audioSource.volume = 1.0f;
        audioSource.loop = true;
        audioSource.time = 0;
        audioSource.Play();

    }
}
