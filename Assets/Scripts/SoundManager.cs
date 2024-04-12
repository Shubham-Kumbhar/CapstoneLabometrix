using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    
    //instance created to access this class from anywhere 
    public static SoundManager instance;

    // Add any audio sources you need in your game
    public AudioSource musicSource;
    public AudioSource sfxSource;
    void Awake()
    {
        // Ensure only one instance of AudioManager exists
        if (instance == null)
        {
            instance = this;
        }
        else if (instance != this)
        {
            Destroy(gameObject);
        }
        DontDestroyOnLoad(gameObject);
    }

    // Play the Music in Scene
    public void PlayMusic(AudioClip clip)
    {
        musicSource.clip = clip;
        musicSource.Play();
    }

    // Play the SFX in Scene
    public void PlaySFX(AudioClip clip)
    {
        sfxSource.PlayOneShot(clip);
    }

    // Stop the Music in Scene
    public void StopMusic()
    {
        musicSource.Stop();
    }

    // Set Volume on music audio Sorce 
    public void SetMusicVolume(float volume)
    {
        musicSource.volume = volume;
    }

    // Set Volume on SFX audio Sorce 
    public void SetSFXVolume(float volume)
    {
        sfxSource.volume = volume;
    }

    
}