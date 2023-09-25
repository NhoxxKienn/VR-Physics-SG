using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class UpdateCollider : MonoBehaviour
{
    public GameObject Pos1;
    public GameObject Pos4;
    BoxCollider boxCollider;
    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position =  (Pos1.transform.position + Pos4.transform.position)/2.0f;
        transform.forward = (Pos4.transform.position - Pos1.transform.position);
        transform.localScale = new Vector3(1, 1, Vector3.Distance(Pos1.transform.position, Pos4.transform.position) * 2.5f);
    }
}
