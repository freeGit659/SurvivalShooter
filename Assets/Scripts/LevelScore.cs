using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelScore : LevelManager
{
    [SerializeField] private int levelScore;
    [SerializeField] protected CardManager cardManager;
    [SerializeField]Text levelScoreText;
    // Start is called before the first frame update
    void Start()
    {
        levelScore = 10;
        UpLevel();
    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager.score >= levelScore)
        {
            levelScore *= 2;
            UpLevel();
            ActiveCard();
        }
        levelScoreText.text = "/" + levelScore;
    }

    private void ActiveCard()
    {
        cardManager.CardCalled();
    }
}
