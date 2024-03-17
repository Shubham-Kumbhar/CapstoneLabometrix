using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resistor : MonoBehaviour, IElectricComponents
{
    public float Resistance;

    public float GetComponentValue()
    {
        return Resistance;
    }
}
