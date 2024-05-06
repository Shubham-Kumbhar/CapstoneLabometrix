using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutSoundManger : MonoBehaviour
{
    public AudioClip buttonClip;
    public AudioClip pushButtonClip;
    public AudioClip BarrierClip;
    public AudioClip musicClip;
    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayMusic(musicClip);
    }
    public void buttonAudio()
    {
        SoundManager.instance.PlaySFX(buttonClip);
    }
    public void PushButtonAudio()
    {
        SoundManager.instance.PlaySFX(pushButtonClip);
    }
    public void BarrierAudio()
    {
        SoundManager.instance.PlaySFX(BarrierClip);
    }

    public void StopMusic()
    {

        SoundManager.instance.StopMusic();
    }
}
