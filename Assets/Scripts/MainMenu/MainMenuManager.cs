using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using TMPro;
using Unity.VisualScripting;
public class MainMenuManager : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Slider SFX, music;
    private void Start()
    {
        SFXSliderValueChanged();
        musicSliderValueChanged();
    }
    public void sceneChanger(int a)
    {
        SceneManager.LoadScene(a);
    }

    public void SFXSliderValueChanged()
    {
        SoundManager.instance.SetSFXVolume(SFX.value);
    }
    public void musicSliderValueChanged()
    {
        SoundManager.instance.SetMusicVolume(music.value);
    }

    public void PlaySFX(AudioClip clip)
    {
        SoundManager.instance.PlaySFX(clip);
    }
    public void PlayMusic(AudioClip clip)
    {
        SoundManager.instance.PlayMusic(clip);
    }
    public void StopMusic()
    {
        SoundManager.instance.StopMusic();
    }
    public void SetSFXVolume(float a)
    {
        SoundManager.instance.SetSFXVolume(a);
    }
    public void SetMusicVolume(float a)
    {
        SoundManager.instance.SetMusicVolume(a);
    }

    public void quit()
    {
        Application.Quit();
    }
}
