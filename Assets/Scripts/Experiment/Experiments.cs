using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experiments : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private ExperimentEvents[] experimentEvent;
    public void LevelCompletions()
    {
        bool a = true;
        foreach (ExperimentEvents Event in experimentEvent)
        {
            a = a & Event.ExperimentCompleted;
        }
        if (a)
        {
            foreach (GameObject objects in gameObjects)
            {
                objects.SetActive(false);
            }
        }
    }

}
