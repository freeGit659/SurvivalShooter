using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public PlayerCtrl playerCtrl;
    [SerializeField] GameObject[] playerAnimation;
    [SerializeField] LeaderBoardCtrl leaderBoardCtrl;
    public LevelScore levelScore;
    public WeaponCtrl weaponCtrl;
    public LevelManager levelManager;
    public StatsCtrl statsCtrl;
   
    public int m_score;
    public int playerHeal;
    public static int score;
    public static int playerHealth;
    public static bool canDo = true;
    public static bool canAttackPlayer = true;

    public float timeSendScore;

    void Start()
    {
        timeSendScore = 0.5f;
        levelManager = GetComponentInChildren<LevelManager>();
        statsCtrl = GetComponentInChildren<StatsCtrl>();
        ResetStaticVar();
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
    private void ResetStaticVar()
    {
        score = 0;
        playerHealth = playerCtrl.healthCtrl.GetMaxHealth();
        canDo = true;
        canAttackPlayer= true;
    }
}
