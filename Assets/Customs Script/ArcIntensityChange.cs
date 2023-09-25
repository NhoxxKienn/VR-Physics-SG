using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcIntensityChange : MonoBehaviour
{
    public GameObject[] arcs;
    public GameObject slider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeIntensity()
    {
        float value = slider.GetComponent<XRSlider>().Value;
        if (value >= 0 && value < 0.2)
        {
            arcs[0].SetActive(true);
            arcs[1].SetActive(true);
            arcs[2].SetActive(true);
            arcs[3].SetActive(false);
            arcs[4].SetActive(false);
            arcs[5].SetActive(false);
            arcs[6].SetActive(false);
            arcs[7].SetActive(false);
            arcs[8].SetActive(false);
        }
        else if (value >= 0.2 && value < 0.4) 
        {
            arcs[0].SetActive(true);
            arcs[1].SetActive(true);
            arcs[2].SetActive(true);
            arcs[3].SetActive(true);
            arcs[4].SetActive(true);
            arcs[5].SetActive(false);
            arcs[6].SetActive(false);
            arcs[7].SetActive(false);
            arcs[8].SetActive(false);
        }
        else if (value >= 0.4 && value < 0.6)
        {
            arcs[0].SetActive(true);
            arcs[1].SetActive(true);
            arcs[2].SetActive(true);
            arcs[3].SetActive(true);
            arcs[4].SetActive(true);
            arcs[5].SetActive(true);
            arcs[6].SetActive(true);
            arcs[7].SetActive(false);
            arcs[8].SetActive(false);
        }
        else
        {
            arcs[0].SetActive(true);
            arcs[1].SetActive(true);
            arcs[2].SetActive(true);
            arcs[3].SetActive(true);
            arcs[4].SetActive(true);
            arcs[5].SetActive(true);
            arcs[6].SetActive(true);
            arcs[7].SetActive(true);
            arcs[8].SetActive(true);
        }
    }
}
