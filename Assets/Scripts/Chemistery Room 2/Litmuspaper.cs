using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Litmuspaper : MonoBehaviour
{
    // Start is called before the first frame update

    public Color Acidic;
    public Color Basic;
    public Color netural;
    public Material mat;
    [Range(0, 1)] float weight;
    public float Speed;
    private void Start()
    {
        mat.color = netural;
    }
    // Update is called once per frame
    public void colorChange(bool isAcidic)
    {
        incWeight();
        if (isAcidic)
            mat.color = Color.Lerp(netural, Acidic, weight);
        else
            mat.color = Color.Lerp(netural, Basic, weight);
    }
    void incWeight()
    {
        weight += Time.deltaTime * Speed;
    }
}
