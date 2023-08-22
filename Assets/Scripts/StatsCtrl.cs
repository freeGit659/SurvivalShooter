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
    public int currentHP;
    public int maxHP;
    public float fireSpeed;
    public float fireDamage;
    public static float FireDamage;

    void Start()
    {
        moveSpeed = movingCtrl.Speed;
        currentHP = healthCtr.CurrentHealth;
        maxHP = healthCtr.MaxHealth;
    }

    void Update()
    {
        movingCtrl.Speed= moveSpeed;
        FireDamage = fireDamage;
    }
}
