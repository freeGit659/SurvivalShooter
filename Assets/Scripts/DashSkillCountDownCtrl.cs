using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashSkillCountDownCtrl : CountDownBarUIManager
{
    [SerializeField] DashManager dashManager;
    void Start()
    {
        dashManager = GetComponentInParent<DashManager>();
    }


    void Update()
    {
        UpdateBar(dashManager.TimeSkillCountDownCurrent, dashManager.TimeSkillCountDownMax);
    }
}
