using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerChem : MonoBehaviour
{
    public AudioClip musicClip;
    public AudioClip pushButtonClip;
    public AudioClip PlacedClip;

    // Start is called before the first frame update
    void Start()
    {
        SoundManager.instance.PlayMusic(musicClip);
    }
    // Update is called once per frame
    public void PushButtonAudio()
    {
        SoundManager.instance.PlaySFX(pushButtonClip);
    }
    public void PlacedAudio()
    {
        SoundManager.instance.PlaySFX(PlacedClip);
    }
}
