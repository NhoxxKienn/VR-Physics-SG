using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBulb : MonoBehaviour
{
    public GameObject bulb;
    ChangeMaterial changeMat;
    public GameObject lightSource;
    private Collider other;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("LightBulb"))
        {
            this.other = other;
            changeMat = bulb.GetComponent<ChangeMaterial>();
            changeMat.SetOtherMaterial();
            lightSource.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("LightBulb"))
        {
            this.other = null;
            changeMat = bulb.GetComponent<ChangeMaterial>();
            changeMat.SetOriginalMaterial();
            lightSource.SetActive(false);
        }
    }

    private void OnDisable()
    {
        if (this.other != null)
        {
            changeMat = bulb.GetComponent<ChangeMaterial>();
            changeMat.SetOriginalMaterial();
            lightSource.SetActive(false);
        }
    }
}
