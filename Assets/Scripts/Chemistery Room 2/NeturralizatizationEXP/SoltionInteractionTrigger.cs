using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoltionInteractionTrigger : MonoBehaviour
{
    [Range(0, 1)] public float weight;
    public ParticleSystem ParticleSystem;
    public float Speed;
    private void Start()
    {
        ParticleSystem.Stop();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Base soluion")
            ParticleSystem.Play();
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Base soluion")
        {
            incWeight();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        ParticleSystem.Stop();
    }
    void incWeight()
    {
        weight += Time.deltaTime * Speed;
    }
}
