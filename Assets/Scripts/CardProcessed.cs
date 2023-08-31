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
        SelectCard(0);
        cardManager.AfterSelect();
    }
    public void PickCard2()
    {
        SelectCard(1);
        cardManager.AfterSelect();
    }
    public void PickCard3()
    {
        SelectCard(2);
        cardManager.AfterSelect();
    }
    public void SelectCard(int card)
    {
        int levelCurrentIndex = cardManager.dataManager.levelScore.LevelCurrent - 1;
        switch (levelCurrentIndex)
        {
            case 0:
                Level1SelectWeapon(card);
                break;
            case 2:
                Level3SelectSkill(card);
                cardManager.dataManager.skillHubPanel.SetActive(true);
                break;
            default:
                statsCtrl.moveSpeed += levelList.levels[levelCurrentIndex].cardCtrl[card].moveSpeed * (statsCtrl.moveSpeed / 100);
                statsCtrl.fireSpeed += levelList.levels[levelCurrentIndex].cardCtrl[card].fireSpeed * (statsCtrl.fireSpeed / 100);
                statsCtrl.fireDamage += levelList.levels[levelCurrentIndex].cardCtrl[card].fireDamage * (statsCtrl.fireDamage / 100);
                statsCtrl.maxHP += levelList.levels[levelCurrentIndex].cardCtrl[card].maxHP;
                statsCtrl.currentHP += levelList.levels[levelCurrentIndex].cardCtrl[card].currentHP;
                break;
        }
    }
    private void Level1SelectWeapon(int card)
    {
        switch (card)
        {
            case 0:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("rifle");
                break;
            case 1:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("shootgun");
                break;
            case 2:
                cardManager.dataManager.weaponCtrl.ActiveWeapon("sniper");
                break;
        }
    }
    private void Level3SelectSkill(int card)
    {
        switch (card)
        {
            case 0:
                cardManager.dataManager.playerCtrl.spaceSkillCtrl.SetSkillForSpace("Bomb");
                break;
            case 1:
                cardManager.dataManager.playerCtrl.spaceSkillCtrl.SetSkillForSpace("Dash");
                break;
            case 2:
                break;
        }
    }
}
