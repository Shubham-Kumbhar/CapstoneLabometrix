using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Experiments : MonoBehaviour
{
    [SerializeField] private GameObject[] gameObjects;
    [SerializeField] private ExperimentEvents[] experimentEvent;
    [SerializeField] private Experiment nextScene;

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
            Invoke(nameof(ChnageScene), 2f);
        }
    }
    public void ChnageScene()
    {
        SceneManager.LoadScene((int)nextScene);
    }

}
public enum Experiment
{
    MainMenu,
    TutRoom0,
    PhysicRoom1,
    ChemisteryRoom2
}