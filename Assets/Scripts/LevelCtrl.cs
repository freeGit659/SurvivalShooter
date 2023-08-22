using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCtrl : LevelList
{
    public CardCtrl[] cardCtrl;
    private void Start()
    {
        cardCtrl = GetComponentsInChildren<CardCtrl>();
    }
}

