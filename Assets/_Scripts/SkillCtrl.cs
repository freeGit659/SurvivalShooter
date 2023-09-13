using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillCtrl : MonoBehaviour
{   public GameObject[] skill;
    [SerializeField] GameObject[] skillHub;
    [SerializeField] protected float timeSkillCountDownMax;
    [SerializeField] protected GameObject[] icon;
    [SerializeField] SkillActivatedCtrl skillActivatedCtrl;
    public int indexIcon;
    //[SerializeField] BombManager bombManager;
    //[SerializeField] DashManager dashManager;
    //[SerializeField] InvisibleManager invisibleManager;
    protected float timeSkillcountDownCurrent;
    public float TimeSkillCountDownMax => timeSkillCountDownMax;
    public float TimeSkillCountDownCurrent => timeSkillcountDownCurrent;
    void Start()
    {
        foreach(GameObject skill in skill)
        {
            skill.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetSkill(int skill)
    {
        this.indexIcon = skill;
        skillActivatedCtrl.SetIcon();
        skillHub[skill].SetActive(true);
        this.skill[skill].SetActive(true);
        
    }
    public void SetSkillFromLevel(int skill)
    {
        SetSkill(skill);
    }
    public virtual void useSkill()
    {
            timeSkillcountDownCurrent = timeSkillCountDownMax;
    }
    public virtual void TimeCountDownLimited()
    {
        if (timeSkillcountDownCurrent <= 0)
        {
            timeSkillcountDownCurrent = 0;
        }
    }
    public virtual void CanUseSkill()
    {

    }
}
