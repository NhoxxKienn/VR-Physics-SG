using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR;


public class DamageController : MonoBehaviour
{
    [SerializeField] private float damage = 10.0f;

    [SerializeField] private ControlHealth _healthController;
    [SerializeField] private AudioClip electrifyAudio;


    [Range(0, 1)]
    public float hapticsIntensity;
    public float hapticsDuration;

    private bool electrifying;
    public AudioSource elecAudioSource;

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
        if (other.CompareTag("Player"))
        {
            InputDevice leftDevice = InputDevices.GetDeviceAtXRNode(XRNode.LeftHand);
            InputDevice rightDevice = InputDevices.GetDeviceAtXRNode(XRNode.RightHand);
            leftDevice.SendHapticImpulse(0, hapticsIntensity, hapticsDuration);
            rightDevice.SendHapticImpulse(0, hapticsIntensity, hapticsDuration);

            elecAudioSource.PlayOneShot(electrifyAudio);
            _healthController.currentPlayerHealth -= damage;
            if (_healthController.currentPlayerHealth < 0)
            {
                _healthController.currentPlayerHealth = 0;
            }

            _healthController.TakeDamage();
        }
    }
}
