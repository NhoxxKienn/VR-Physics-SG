using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArcTrigger : MonoBehaviour
{
    public GameObject Arcsbase;

    public GameObject Pos4;

    private void Update()
    {
        if (Vector3.Distance(transform.position, Pos4.transform.position) >= 1.3f)
        {
            Arcsbase.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Arcsbase.SetActive(true);
    }
}
