using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLevelUICtrl : MonoBehaviour
{
    [SerializeField] protected TMP_Text playerLevel;
    [SerializeField] protected LevelScore level;
    void Start()
    {
        playerLevel = GetComponent<TMP_Text>();
    }

    void Update()
    {
        playerLevel.text =level.levelCurrentByScore.ToString();
    }
}
