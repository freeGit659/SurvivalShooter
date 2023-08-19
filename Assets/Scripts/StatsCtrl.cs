using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StatsCtrl : MonoBehaviour
{
    [SerializeField] PlayerCtrl playerCtrl;
    [SerializeField] HealthCtr healthCtr;
    [SerializeField] WeaponCtrl weaponCtrl;
    [SerializeField] PlayerMoving movingCtrl;

    [Header("Player Stats")]
    [Space(50)]
    public float moveSpeed;
    public int healthCurrent;
    public int healthMax;
    public float speedFireDefault;

    void Start()
    {
        moveSpeed = movingCtrl.Speed;
        healthCurrent = healthCtr.CurrentHealth;
        healthMax = healthCtr.MaxHealth;
    }

    void Update()
    {
        
    }
}
