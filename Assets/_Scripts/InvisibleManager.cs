using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleManager : SkillCtrl
{
    [SerializeField] protected PlayerCtrl playerCtrl;
    [SerializeField] protected InvisibleSkillCountDownCtr invisibleSkillCountDownCtrl;
    [SerializeField] protected float timeInvesible;

    public float TimeInvesible
    {
        get { return timeInvesible; }
        set { timeInvesible = value; }
    }
    void Start()
    {
        invisibleSkillCountDownCtrl = GetComponentInChildren<InvisibleSkillCountDownCtr>();
        this.timeSkillcountDownCurrent = 0;
    }

    
    void Update()
    {
        if (!DataManager.canDo) return;
        this.timeSkillcountDownCurrent -= Time.deltaTime;
        TimeCountDownLimited();
        this.useSkill();
    }
    public override void useSkill()
    {
        if (Input.GetKeyUp(KeyCode.R) && timeSkillcountDownCurrent == 0)
        {
            StartCoroutine(playerCtrl.GetHurt(timeInvesible));
            this.invisibleSkillCountDownCtrl.ActiveBar(true);
            this.timeSkillcountDownCurrent = this.timeSkillCountDownMax;
        }
    }
    public override void TimeCountDownLimited()
    {
        if (this.timeSkillcountDownCurrent <= 0)
        {
            this.timeSkillcountDownCurrent = 0;
            this.invisibleSkillCountDownCtrl.ActiveBar(false);
        }
    }

}
