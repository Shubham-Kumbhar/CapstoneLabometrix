using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenuSoundManager : MonoBehaviour
{
    public Button[] buttons;
    public AudioClip playClip;
    public AudioClip musicClip;



    private void Start()
    {
        foreach (var button in buttons)
        {
            button.onClick.AddListener(() => SoundManager.instance.PlaySFX(playClip));
        }
        SoundManager.instance.PlayMusic(musicClip);
    }

    public void StopMusic()
    {

        SoundManager.instance.StopMusic();
    }
}
