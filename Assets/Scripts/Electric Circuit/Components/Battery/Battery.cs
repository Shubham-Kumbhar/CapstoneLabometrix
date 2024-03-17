using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour,IElectricComponents
{
    public float Volatage;
    public float GetComponentValue()
    {
        return Volatage;
    }
}
