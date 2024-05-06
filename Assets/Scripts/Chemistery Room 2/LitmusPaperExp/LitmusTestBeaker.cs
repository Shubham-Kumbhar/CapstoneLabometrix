using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitmusTestBeaker : MonoBehaviour
{
    public bool isAcidic;
    bool isLitmusPaper;
    public ExperimentEvents EventComplition;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Litmus")
        {
            isLitmusPaper = true;
        }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Litmus" && isLitmusPaper)
        {
            var Litmuspaper = other.GetComponent<Litmuspaper>();
            Litmuspaper.colorChange(isAcidic);
            if (Litmuspaper.ProcessComplete)
            {
                EventComplition.ExperimentCompleted = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.tag == "Litmus")
        {
            isLitmusPaper = false;
        }
    }
}
