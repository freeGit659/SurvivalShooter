using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    [SerializeField] GameObject[] playerAnimation;
    public LevelScore levelScore;
    public WeaponCtrl weaponCtrl;
    public LevelManager levelManager;
    public static int score;
    public int m_score;
    public static int playerHealth;
    public int playerHeal;

    void Start()
    {
        score= 0;
        playerHealth= playerCtrl.healthCtrl.GetMaxHealth();
        levelManager = GetComponentInChildren<LevelManager>();
    }

    // Update is called once per frame
    void Update()
    {
        m_score= score;
        playerCtrl.healthCtrl.SetHealth(playerHealth);
        playerHeal = playerHealth;
    }

    protected void SelectWeapon(string weapon)
    {
        weaponCtrl.ActiveWeapon(weapon);
    }

}
