using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : SkillCtrl
{
    [SerializeField] private SpawnSkillCtr spawnSkillCtr;
    [SerializeField] protected BombSkillCountDownCtrl bombSkillCountDownCtrl;
    public int damage;


    
    void Start()
    {
        spawnSkillCtr =GetComponentInChildren<SpawnSkillCtr>();
        bombSkillCountDownCtrl = GetComponentInChildren<BombSkillCountDownCtrl>();
        this.timeSkillcountDownCurrent = 0;
        damage = 200;
    }

    // Update is called once per frame
    void Update()
    {
        if (!DataManager.canDo) return;
        this.timeSkillcountDownCurrent -= Time.deltaTime;
        TimeCountDownLimited();
        this.useSkill();    
    }
    public override void useSkill()
    {
        if (Input.GetKeyUp(KeyCode.Q) && timeSkillcountDownCurrent == 0)
        {
            this.spawnSkillCtr.Spawn();
            this.bombSkillCountDownCtrl.ActiveBar(true);
            this.timeSkillcountDownCurrent = this.timeSkillCountDownMax;
        }
    }
    public override void TimeCountDownLimited()
    {
        if (this.timeSkillcountDownCurrent <= 0)
        {
            this.timeSkillcountDownCurrent = 0;
            this.bombSkillCountDownCtrl.ActiveBar(false);
        }
    }

}
