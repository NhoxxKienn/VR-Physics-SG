using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetThingOnFire : MonoBehaviour
{
    private Collider other;
    public GameObject slider;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            if (slider.GetComponent<XRSlider>().Value > 0.5)
            {
                this.other = other;
                other.gameObject.GetComponent<SetOnFire>().SetFire(true);
            }
            else
            {
                this.other = other;
                other.gameObject.GetComponent<SetOnFire>().SetFire(false);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Fire"))
        {
            this.other = null;
            other.gameObject.GetComponent<SetOnFire>().SetFire(false);
        }
    }

    private void OnDisable()
    {
        if (other != null)
        {
            other.gameObject.GetComponent<SetOnFire>().SetFire(false);
        }
    }

}
