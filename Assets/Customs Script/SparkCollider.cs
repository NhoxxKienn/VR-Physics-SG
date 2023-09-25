using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class SparkCollider : MonoBehaviour
{
    public SphereCollider collider;
    public float minSize = .08f;
    public float incrSize = .12f;
    public float minNoise = .01f;
    public float incrNoise = .09f;
    public GameObject target;
    public GameObject effect;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void ChangeColliderSize()
    {
        collider.radius = minSize + incrSize * target.GetComponent<XRSlider>().Value;
        effect.GetComponent<VisualEffect>().SetFloat("NoisePower", minNoise + incrNoise * target.GetComponent<XRSlider>().Value);
    }
 }
