using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] GameObject cardCanvas;
    [SerializeField] CardProcessed cardProcessed;
    [SerializeField] UICardCtrl[] cardInfo;
    [SerializeField] LevelList levelList;
    [SerializeField] GameObject panelCard;
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
        DataManager.canDo = true;
        
    }
   public void CardCalled()
    {

        StartCoroutine(ActivePanelCard());
        cardCanvas.SetActive(true);
        int levelCurrentIndex = dataManager.levelScore.LevelCurrent - 1;
        for (int i = 0; i < cardInfo.Length; i++)
        {
            cardInfo[i].SetInfo(levelList.levels[levelCurrentIndex].cardCtrl[i].sprite, levelList.levels[levelCurrentIndex].cardCtrl[i].infomationText);
        }
    }
    public IEnumerator ActivePanelCard()
    {
        Time.timeScale = 1f;
        DataManager.canDo = false;
        panelCard.SetActive(true);
        yield return new WaitForSeconds(1f);
        panelCard.SetActive(false);
        Time.timeScale = 0f;
    }
}
