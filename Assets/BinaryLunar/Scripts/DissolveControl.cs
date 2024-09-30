using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveControl : MonoBehaviour
{
    public float dissolveAmt;
    public float dissolveSpeed;
    public bool isDissolving;
    [ColorUsage(true,true)]
    public Color fadeOutColor;
    [ColorUsage(true, true)]
    public Color fadeInColor;

    public Material mat;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
