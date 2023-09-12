using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleSkillCountDownCtr : CountDownBarUIManager
{
    [SerializeField] protected InvisibleManager invisibleManager;   
    void Start()
    {
        invisibleManager = GetComponentInParent<InvisibleManager>();
    }

    // Update is called once per frame
    void Update()
    {
        UpdateBar(invisibleManager.TimeSkillCountDownCurrent, invisibleManager.TimeSkillCountDownMax);
    }
}
