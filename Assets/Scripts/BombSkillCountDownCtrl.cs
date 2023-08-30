using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombSkillCountDownCtrl : CountDownBarUIManager
{
    [SerializeField] BombManager bombManager;
    void Start()
    {
        bombManager = GetComponentInParent<BombManager>();
    }

    
    void Update()
    {
        UpdateBar(bombManager.TimeSkillCountDownCurrent, bombManager.TimeSkillCountDownMax);
    }
    
}
