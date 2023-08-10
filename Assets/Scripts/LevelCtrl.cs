using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelCtrl : MonoBehaviour
{
    private int levelScore = 0;
    Text levelScoreText;
    // Start is called before the first frame update
    void Start()
    {
        levelScoreText = GetComponent<Text>();
        levelScore = 10;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelScore == DataManager.score) levelScore += 20;
        levelScoreText.text = "/" + levelScore;
    }
}
