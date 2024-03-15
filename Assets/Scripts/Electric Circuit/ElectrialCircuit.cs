using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using Unity.PlasticSCM.Editor.WebApi;
using UnityEngine;

public class ElectrialCircuit : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private SeriesResisterGroup resisterGroup;
    ParallerResisterGroup[] parallerResisterGroups;
    float[] seriesResistorGroup;
    void Start()
    {
        Debug.Log(CurrentCalculation());
    }
    void Update()
    {

    }
    float CurrentCalculation()
    {
        var Volatage = 10f;
        return Volatage / ClaculateEquvalentReistance();
    }
    float ClaculateEquvalentReistance()
    {
        parallerResisterGroups = resisterGroup.ParallerResisters;
        seriesResistorGroup = resisterGroup.SeriesResister;
        return SeriesEquvalnetReistancecalculator();
    }

    float ParelleEquvaltenResistanceCalculator()
    {
        var TotalEQresistance = 0f;
        foreach (ParallerResisterGroup parellelResistors in parallerResisterGroups)
        {
            var resistors = parellelResistors.parallelResistor;
            var EquvalentReistance = 0f;
            foreach (float resistor in resistors)
            {
                EquvalentReistance += 1 / resistor;
            }
            TotalEQresistance += TotalEQresistance;
        }
        return TotalEQresistance;
    }
    float SeriesEquvalnetReistancecalculator()
    {
        var TotalEQresistance = 0f;
        foreach (float resistor in seriesResistorGroup)
        {
            TotalEQresistance += resistor;
        }
        return TotalEQresistance + ParelleEquvaltenResistanceCalculator();
    }

}
