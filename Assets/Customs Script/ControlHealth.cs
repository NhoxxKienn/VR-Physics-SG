using System.Collections;
using System.Collections.Generic;
using System.Transactions;
using UnityEngine;
using UnityEngine.Rendering;

public class ControlHealth : MonoBehaviour
{
    public Volume m_Volume;


    public float currentPlayerHealth = 100.0f;
    [SerializeField] private float maxPlayerHealth = 100.0f;

    [SerializeField] private int regenRate = 1;
    private bool canRegen = false;
    [SerializeField] private float healCooldown = 3.0f;
    [SerializeField] private float maxHealCooldown = 3.0f;
    [SerializeField] private bool startCooldown = false;

    [SerializeField] private float hurtTimer = 0.1f;
    [SerializeField] private AudioClip hurtAudio;
    private AudioSource healthAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        healthAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (startCooldown)
        {
            healCooldown -= Time.deltaTime;
            if (healCooldown <= 0 ) 
            {
                canRegen = true;
                startCooldown = false;
            }
        }

        if (canRegen)
        {
            if (currentPlayerHealth <= maxPlayerHealth) 
            {
                currentPlayerHealth += Time.deltaTime * regenRate;
                UpdateHealth();
            }
            else
            {
                currentPlayerHealth = maxPlayerHealth;
                healCooldown = maxHealCooldown;
                canRegen = false;
            }
        }
    }

    void UpdateHealth()
    {
        m_Volume.weight = 1 - (currentPlayerHealth / maxPlayerHealth);
    }

    IEnumerator HurtFlash()
    {
        healthAudioSource.PlayOneShot(hurtAudio);
        yield return new WaitForSeconds(hurtTimer);

    }

    public void TakeDamage()
    {
        if (currentPlayerHealth > 0)
        {
            canRegen = false;
            StartCoroutine(HurtFlash());
            UpdateHealth();
            healCooldown = maxHealCooldown;
            startCooldown = true;
        }
    }
}
