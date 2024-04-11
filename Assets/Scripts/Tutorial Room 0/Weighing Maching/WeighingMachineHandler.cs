using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class WeighingMachineHandler : MonoBehaviour
{
    [SerializeField] private ExperimentEvents CompletionEvent;
    [SerializeField] private PlatformWeightCounter P1;
    [SerializeField] private PlatformWeightCounter P2;
    [SerializeField] private TextMeshProUGUI Weight1;
    [SerializeField] private TextMeshProUGUI Weight2;

    private void Update()
    {
        Weight1.text = P1.Weight.ToString() + " kg";
        Weight2.text = P2.Weight.ToString() + " kg";
        if (P1.Weight == P2.Weight && (P1.Weight != 0 || P2.Weight != 0))
        {
            CompletionEvent.ExperimentCompleted = true;
        }
        else
        {
            CompletionEvent.ExperimentCompleted = false;
        }
    }
}
