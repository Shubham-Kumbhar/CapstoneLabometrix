using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "SeriesResisterGroup", menuName = "ElectricCircuit/SeriesResisterGroup", order = 0)]
public class SeriesResisterGroup : ScriptableObject
{
    public ParallerResisterGroup [] ParallerResisters;
    public float [] SeriesResister;
}

