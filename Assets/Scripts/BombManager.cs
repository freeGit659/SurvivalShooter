using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombManager : SpaceSkillCtrl
{
    [SerializeField] private SpawnSkillCtr spawnSkillCtr;
    [SerializeField] protected BombSkillCountDownCtrl bombSkillCountDownCtrl;


    
    void Start()
    {
        spawnSkillCtr =GetComponentInChildren<SpawnSkillCtr>();
        timeSkillcountDownCurrent = 0;
        icon.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (!DataManager.canDo) return;
        timeSkillcountDownCurrent -= Time.deltaTime;
        TimeCountDownLimited();
        this.useSkill();    
    }
    public override void useSkill()
    {
        if (Input.GetKeyUp(KeyCode.Space) && timeSkillcountDownCurrent == 0)
        {
            spawnSkillCtr.Spawn();
            bombSkillCountDownCtrl.ActiveBar(true);
            timeSkillcountDownCurrent = timeSkillCountDownMax;
        }
    }

}
