using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] GameObject cardCanvas;
    [SerializeField] CardProcessed cardProcessed;
    [SerializeField] UICardCtrl[] cardInfo;
    [SerializeField] LevelList levelList;
    public DataManager dataManager;
    // Start is called before the first frame update
    void Start()
    {
        cardProcessed = GetComponentInChildren<CardProcessed>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AfterSelect()
    {
        cardCanvas.SetActive(false);
        Time.timeScale = 1.0f;
        
    }
    public void CardCalled()
    {
        cardCanvas.SetActive(true);
        Time.timeScale = 0f;
        for(int i= 0; i < cardInfo.Length; i++)
        {
            if (dataManager.levelScore.LevelCurrent == 1) cardInfo[i].SetInfo(levelList.levels[0].cardCtrl[i].sprite,levelList.levels[0].cardCtrl[i].infomationText);
            if (dataManager.levelScore.LevelCurrent == 2) cardInfo[i].SetInfo(levelList.levels[1].cardCtrl[i].sprite, levelList.levels[1].cardCtrl[i].infomationText);
        }
        
    }
}
