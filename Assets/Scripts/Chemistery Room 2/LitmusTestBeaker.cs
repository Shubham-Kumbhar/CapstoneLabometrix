using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LitmusTestBeaker : MonoBehaviour
{
    public bool isAcidic;
    bool isLitmusPaper;
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
            other.GetComponent<Litmuspaper>().colorChange(isAcidic);
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
