using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeIntensity : MonoBehaviour
{
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateIntensity()
    {
        float value = slider.GetComponent<XRSlider>().Value;
        GetComponent<Light>().intensity = .01f +  value;
    }
}
