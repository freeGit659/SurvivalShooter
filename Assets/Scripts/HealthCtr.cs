using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthCtr : MonoBehaviour
{
    [SerializeField] private Image[] hearts;
    [SerializeField] private Sprite fullHeart;
    [SerializeField] private Sprite emptyHeart;
    [SerializeField] private PlayerCtrl player;
    private int currentHealth;
    public int CurrentHealth
    {
        get { return currentHealth; }
        set { currentHealth = value; }
    }

    private int maxHealth;
    public int MaxHealth
    {
        get { return maxHealth; }
        set { maxHealth = value; }
    }
    private void Awake()
    {
        maxHealth = 3;
        currentHealth = maxHealth;
    }


    void Update()
    {
        foreach(Image img in hearts)
        {
            img.sprite = emptyHeart;

        }
        for (int i = 0; i < currentHealth; i++)
        {
            hearts[i].sprite = fullHeart;
        }    
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
    public int GetMaxHealth()
    {
        return maxHealth;
    }
}
