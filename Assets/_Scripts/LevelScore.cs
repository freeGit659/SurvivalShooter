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
            ActiveCard();
            this.levelCurrentByScore++;
        }
        levelScoreText.text = "/" + levelScore;
    }

    private void ActiveCard()
    {
        cardManager.CardCalled();
    }
}
