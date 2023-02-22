using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HealthBar : MonoBehaviour
{
    private Image healthBar;
    public float currentHealth;
    private float MaxHealth=100f;
    GameManager gameManager;

    //public bool healthPacket=true;

    private void Start()
    {
        healthBar = GetComponent<Image>();
        gameManager = FindObjectOfType<GameManager>();
    }

    private void Update()
    {
        currentHealth = gameManager.Health;
        healthBar.fillAmount = currentHealth / MaxHealth;
    }
}
