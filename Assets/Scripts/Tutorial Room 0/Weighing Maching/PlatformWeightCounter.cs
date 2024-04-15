using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformWeightCounter : MonoBehaviour
{
    public float Weight;
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Weight")
        Weight += other.GetComponent<Rigidbody>().mass;
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Weight")
        Weight -= other.GetComponent<Rigidbody>().mass;
    }
}
