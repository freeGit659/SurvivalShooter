using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using UnityEngine.UI;
using Unity.VisualScripting;

public class LeaderBoardCtrl : MonoBehaviour
{
    [SerializeField] InputNameCtrl inputNameCtrl;
    public int playerScore;
    public string playerNameStr;
    public int playerRank;
    public int id;
    int maxScores = 100;
    float timeUpdate = 2;

    public Text[] Entries;

    // Update is called once per frame
    public void SubmitScore()
    {
        LootLockerSDKManager.SubmitScore(playerNameStr, playerScore, "board", (response) =>
        {
            if (response.success)
            {
                Debug.Log("Submit Sucess");
            }
            else
            {
                Debug.Log("Submit Failed");
            }
            LootLockerSDKManager.GetMemberRank("board", playerNameStr, (response) =>
            {
                if (response.success)
                {
                    Debug.Log("Successful");
                    playerRank = response.rank;
                }
                else
                {
                    Debug.Log("failed: " + response.Error);
                }
            });
        });
    }
    private void Update()
    {
        playerScore = DataManager.score;
        playerNameStr = inputNameCtrl.playerName;
        timeUpdate -= Time.deltaTime;
        if (timeUpdate < 0)
        {
            Show();
            timeUpdate = 2;
        }

    }
    void Start()
    {
        timeUpdate = 1;
        LootLockerSDKManager.StartGuestSession((response) =>
        {
            if (!response.success)
            {
                Debug.Log("error starting LootLocker session");

                return;
            }

            Debug.Log("successfully started LootLocker session");
        });
    }
    public void Show()
    {
        int playerRankUp = playerRank - 1;
        int playerRankDown = playerRank + 1;
        LootLockerSDKManager.GetScoreList("board", maxScores, (response) =>
        {
            if (response.success)
            {
                LootLockerLeaderboardMember[] scores = response.items;
                if (scores.Length > 0 && scores.Length <= 5)
                {
                    for (int i = 0; i < scores.Length; i++)
                    {
                        Entries[i].text = (scores[i].rank + ".  " + scores[i].member_id + " - " + scores[i].score);
                        if (playerRank == scores[i].rank) { Entries[i].color = Color.red; }
                        else { Entries[i].color = Color.black; }
                    }
                }
                else if (scores.Length > 5)
                {
                    if (playerRank > 5)
                    {
                        for (int i = 0; i < 3; i++)
                        {
                            Entries[i].text = (scores[i].rank + ".  " + scores[i].member_id + " - " + scores[i].score);
                            if (playerRank == scores[i].rank) { Entries[i].color = Color.red; }
                            else { Entries[i].color = Color.black; }
                        }
                        Entries[3].text = ((playerRankUp) + ".  " + scores[playerRankUp - 1].member_id + " - " + scores[playerRankUp - 1].score);
                        Entries[3].color = Color.white;
                        Entries[4].text = (playerRank + ".  " + playerNameStr + " - " + scores[playerRank - 1].score);
                        Entries[4].color = Color.red;
                    }
                    else
                    {
                        for (int i = 0; i < 5; i++)
                        {
                            Entries[i].text = (scores[i].rank + ".  " + scores[i].member_id + " - " + scores[i].score);
                            if (playerRank == scores[i].rank) { Entries[i].color = Color.red; }
                            else { Entries[i].color = Color.black; }
                        }
                    }
                }
            }
            else
            {
                Debug.Log("Submit Failed");
            }
        });
    }
}