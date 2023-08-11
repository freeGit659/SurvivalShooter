using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCtr : MonoBehaviour
{
    private int currentHealth;
    private int maxHealth;
    private void Awake()
    {
        maxHealth = 3;
        currentHealth = maxHealth;
    }


    void Update()
    {
        
    }

    public void SetHealth(int health)
    {
        if (health >= maxHealth) currentHealth = maxHealth;
        else currentHealth = health;
    }
    
    public int GetHealth()
    {
        return currentHealth;
    }
}
