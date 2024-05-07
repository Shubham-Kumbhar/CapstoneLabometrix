using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public ExperimentEvents[] ExperimentEvents;
    [SerializeField] private GameObject[] CompletionIndecators;
    [SerializeField] private AudioClip SuccessAudioClip;
    int index, previos;
    public static LevelManager Instance;
    void Awake()
    {
        if (LevelManager.Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        foreach (ExperimentEvents Events in ExperimentEvents)
        {
            Events.ExperimentCompleted = false;
        }
    }

    private void Update()
    {
        index = 0;
        foreach (ExperimentEvents events in ExperimentEvents)
        {
            if (events.ExperimentCompleted)
            {
                index++;
                if (index > previos)
                {
                    SoundManager.instance.PlaySFX(SuccessAudioClip);
                    previos = index;
                }
            }
        }

        foreach (GameObject Object in CompletionIndecators) Object.SetActive(false);
        for (int i = 0; i < index; i++)
        {
            CompletionIndecators[i].SetActive(true);
        }

    }
}
