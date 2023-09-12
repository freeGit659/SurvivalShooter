using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverCtrl : MonoBehaviour
{
    [SerializeField] LeaderBoardCtrl leaderBoardCtrl;
    [SerializeField] Text nameText;
    [SerializeField] Text scoreText;
    [SerializeField] Text rankText;
    void Start()
    {
        nameText.text = leaderBoardCtrl.playerNameStr;
        scoreText.text = leaderBoardCtrl.playerScore.ToString();
        rankText.text = leaderBoardCtrl.playerRank.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
