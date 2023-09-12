using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerNameCtrl : MonoBehaviour
{
    [SerializeField] protected TMP_Text playerName;
    [SerializeField] protected LeaderBoardCtrl leaderBoardCtrl;
    void Start()
    {
        playerName= GetComponent<TMP_Text>();
    }

    // Update is called once per frame
    void Update()
    {
        playerName.text = leaderBoardCtrl.playerNameStr;
    }
}
