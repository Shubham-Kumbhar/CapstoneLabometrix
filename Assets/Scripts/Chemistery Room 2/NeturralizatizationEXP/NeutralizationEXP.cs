using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NeutralizationEXP : MonoBehaviour
{
    public ExperimentEvents EventComplition;
    public SoltionInteractionTrigger soltionInteractionTrigger;



    private void Update()
    {
        if (soltionInteractionTrigger.weight >= 1)
        {
            EventComplition.ExperimentCompleted = true;
        }
    }



}
