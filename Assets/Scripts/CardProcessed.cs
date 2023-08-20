using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardProcessed : MonoBehaviour
{
    [SerializeField] CardManager cardManager;
    [SerializeField] LevelList levelList;
    [SerializeField] StatsCtrl  statsCtrl;
    void Start()
    {
        cardManager = GetComponentInParent<CardManager>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void PickCard1()
    {
        SelectCard(1);
        cardManager.AfterSelect();
    }
    public void PickCard2()
    {
        SelectCard(2);
        cardManager.AfterSelect();

    }
    public void PickCard3()
    {
        SelectCard(3);
        cardManager.AfterSelect();
    }
    public void SelectCard(int card)
    {
        switch (cardManager.dataManager.levelScore.LevelCurrent)
        {
            case 1:
                Level1SelectWeapon(card);
                break;
            case 2:
                Level2StatsUpgrade(card);
                break;
         

        }
    }
    private void Level1SelectWeapon(int card)
    {
        switch (card)
        {
            case 1:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("rifle");
                break;
            case 2:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("shootgun");
                break;
            case 3:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("sniper");
                break;
        }
    }
    private void Level2StatsUpgrade(int card)
    {
        switch (card)
        {
            case 1:
                statsCtrl.speedFireDefault += (statsCtrl.speedFireDefault * 20) / 100;
                break;
            case 2:
                statsCtrl.moveSpeed += (statsCtrl.moveSpeed * 20) / 100;
                break;
            case 3:
                statsCtrl.healthMax += 1;
                statsCtrl.healthCurrent += 1;
                break;


        }
    }
}
