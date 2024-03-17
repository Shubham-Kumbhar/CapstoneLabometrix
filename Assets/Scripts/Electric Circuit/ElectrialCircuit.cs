using System;
using System.Collections;
using UnityEngine;
using TMPro;

public class ElectrialCircuit : MonoBehaviour
{
    // Start is called before the first frame update
    private float current;
    [SerializeField] private ExperimentEvents CompletionEvent;
    [SerializeField] private Light lightBulb;
    [SerializeField] private float currentToAchive;
    [SerializeField] private TextMeshProUGUI Text;
    [SerializeField] private BulbObject bulb;
    [SerializeField] private BatteyVoltage voltage;
    [SerializeField] private SeriesResisterGroup resisterGroup;
    ParallerResisterGroup[] parallerResisterGroups;
    bool isBrokenCircuit;
    float[] seriesResistorGroup;
    void Start()
    {

    }
    void Update()
    {
        current = CurrentCalculation();
        Text.text = current.ToString();
        TunonLightBulb();
    }
    void TunonLightBulb()
    {
        if (current == currentToAchive && bulb.isPlaced)
        {
            lightBulb.gameObject.SetActive(true);
            CompletionEvent.ExperimentCompleted =true;
        }
        else
        {
            lightBulb.gameObject.SetActive(false);
            CompletionEvent.ExperimentCompleted =false;
        }
    }
    float CurrentCalculation()
    {
        var Volatage = voltage.Volatage;
        var Resistance = ClaculateEquvalentReistance();
        if (Resistance == 0f)
        {
            return 0;
        }
        else
        {
            return Volatage / Resistance;
        }
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
                if (resistor == 0)
                    continue;
                else
                    EquvalentReistance += 1 / resistor;
            }
            TotalEQresistance += EquvalentReistance;
        }
        return TotalEQresistance;
    }
    float SeriesEquvalnetReistancecalculator()
    {
        var TotalEQresistance = 0f;
        foreach (float resistor in seriesResistorGroup)
        {
            if (resistor == 0)
            {
                return 0f;
            }
            else
            {
                TotalEQresistance += resistor;
            }
        }
        var parallerEQResistance = ParelleEquvaltenResistanceCalculator();
        if (parallerEQResistance == 0)
        {
            return 0f;
        }
        else
        {
            return TotalEQresistance + parallerEQResistance;
        }
    }

}
