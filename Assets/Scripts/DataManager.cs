using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    [SerializeField] PlayerCtrl playerCtrl;
    public static int score;
    public int m_score;
    public static int playerHealth;
    public int playerHeal;

    void Start()
    {
        score= 0;
        playerHealth= playerCtrl.healthCtrl.GetMaxHealth();
    }

    // Update is called once per frame
    void Update()
    {
        m_score= score;
        playerCtrl.healthCtrl.SetHealth(playerHealth);
        playerHeal = playerHealth;
    }

}
