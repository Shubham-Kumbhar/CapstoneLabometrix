using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TitrationExp : MonoBehaviour
{
    public ExperimentEvents ExperimetCompltion;
    public GameObject[] turnOnObjects;
    bool turnOnBool = true;
    public bool IsInteracting;
    public float SppedofFlow;
    [Range(0, 1)] public float fullamout;
    [Range(0, 1)] public float BeakerFullAmout;
    public float BeakerFillSpeed;
    public Transform Pos;
    public ParticleSystem ParticleSystem;
    public MeshRenderer ChnageMaterial;
    public Color lerpstartColour;
    public Color lerpsendColour;
    public float ColourChangeSpeed;
    [Range(0, 1)] float lerptime = 0;
    private void Start()
    {
        ParticleSystem.Stop();
    }
    public void onSelectenterEventFunc()
    {
        IsInteracting = true;
        ParticleSystem.Play();
        // Particle Sysatem on
    }
    public void onSelectexitEventFunc()
    {
        IsInteracting = false;
        ParticleSystem.Stop();
        // Particle Sysatem off
    }
    private void Update()
    {
        if (IsInteracting)
        {
            var ray = new Ray(Pos.position, -transform.up);
            RaycastHit hit;
            if (fullamout > 0)
            {
                fullamout -= Time.deltaTime * SppedofFlow;
                if (Physics.Raycast(ray, out hit) && BeakerFullAmout < 0.5f)
                {
                    if (hit.transform.gameObject.tag == "Baeker")
                    {
                        BeakerFullAmout += Time.deltaTime * BeakerFillSpeed;
                    }
                }
            }
            else
            {
                Debug.Log("Empty");
                ParticleSystem.Stop();
                //Particle Sysatem off
            }
        }
        if (BeakerFullAmout > 0.5f)
        {
            lerptime += Time.deltaTime * ColourChangeSpeed;
            ChnageMaterial.material.color = Color.Lerp(lerpstartColour, lerpsendColour, lerptime);
            ExperimetCompltion.ExperimentCompleted = true;
            //Complete
            Debug.Log("Completion");
            if (turnOnBool)
            {
                turnOnBool = false;
                foreach (var item in turnOnObjects)
                {
                    item.SetActive(true);
                }
            }
        }
    }
}
