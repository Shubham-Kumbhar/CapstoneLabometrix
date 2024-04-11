using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiments : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private ExperimentEvents[] experimentEvent;
    private void Start()
    {
        experimentEvent = LevelManager.Instance.ExperimentEvents;
    }
    public void LevelCompletions()
    {
        foreach (ExperimentEvents Event in experimentEvent)
        {
            if (!Event.ExperimentCompleted)
            {
                return;
            }
        }
        foreach (GameObject objects in gameObjects)
        {
            objects.SetActive(false);
        }
    }

}
