using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    public ExperimentEvents [] ExperimentEvents;
    public static LevelManager Instance;
    void Start()
    {
        if (LevelManager.Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
        foreach(ExperimentEvents Events in ExperimentEvents)
        {
            Events.ExperimentCompleted =false;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
