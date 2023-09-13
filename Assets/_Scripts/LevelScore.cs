using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : LevelManager
{
    [SerializeField] private int levelScore;
    public int levelCurrentByScore;
    
    [SerializeField] protected CardManager cardManager;
    [SerializeField]Text levelScoreText;
    [SerializeField] SkillCtrl skillCtrl;
    // Start is called before the first frame update
    void Start()
    {
        levelScore = 5;
        levelCurrentByScore= 1;
        this.UpLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager.score >= levelScore)
        {
            levelScore *= 2;
            this.UpLevel();
            this.levelCurrentByScore++;
            switch (this.levelCurrentByScore)
            {
                case 3:
                    cardManager.dataManager.skillHubPanel.SetActive(true);
                    skillCtrl.SetSkillFromLevel(1);
                    break;
                case 5:
                    skillCtrl.SetSkillFromLevel(0);
                    break;
                case 8:
                    skillCtrl.SetSkillFromLevel(2);
                    break;
                default:
                    ActiveCard();
                    break;

            }      
        }
        levelScoreText.text = "/" + levelScore;
    }

    private void ActiveCard()
    {
        cardManager.CardCalled();
    }
}
