using System;
using UnityEngine;
using TMPro;

public class Damageable : MonoBehaviour
{
    [SerializeField] int maxHealth = 10;
    public int health = 5;

    [SerializeField] GameObject objectToEnableWhenDie;
    [SerializeField] TMP_Text uiText;

    private void Start()
    {
        UpdateText();
    }

    void OnTriggerEnter(Collider other)
    {

        Damager damager = other.GetComponentInChildren<Damager>();

        if (damager != null && health > 0)
        {
            health -= Mathf.Min(damager.damage, health);
            health = Mathf.Clamp(health, 0, maxHealth);

            UpdateText();

            if (health == 0)
            {
                DisableObject();
            }
        }
    }

    void UpdateText()
    {
        if (uiText != null)
        {
            uiText.text = $"Health: {health}";
        }
    }

    void DisableObject() 
    {
        if(objectToEnableWhenDie != null)
            objectToEnableWhenDie.SetActive(true);
    }
}
