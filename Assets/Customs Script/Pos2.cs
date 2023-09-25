using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pos2 : MonoBehaviour
{
    public GameObject Pos1;
    public GameObject Pos4;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vector = (Pos4.transform.position - Pos1.transform.position)/3f;

        transform.position = (Pos1.transform.position + vector );
    }
}
