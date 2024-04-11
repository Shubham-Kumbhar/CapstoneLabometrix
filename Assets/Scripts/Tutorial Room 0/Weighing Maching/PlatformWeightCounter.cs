using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformWeightCounter : MonoBehaviour
{
    public float Weight;
    private void OnTriggerEnter(Collider other)
    {
        Weight += other.GetComponent<Rigidbody>().mass;
    }
    private void OnTriggerExit(Collider other)
    {
        Weight -= other.GetComponent<Rigidbody>().mass;
    }
}
