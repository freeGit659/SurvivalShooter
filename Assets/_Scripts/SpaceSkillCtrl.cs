using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceSkillCtrl : MonoBehaviour
{
    [SerializeField] GameObject[] skill;
    [SerializeField] GameObject[] skillHub;
    [SerializeField] protected float timeSkillCountDownMax;
    [SerializeField] protected GameObject icon;
    //[SerializeField] BombManager bombManager;
    //[SerializeField] DashManager dashManager;
    //[SerializeField] InvisibleManager invisibleManager;
    public string skillSpaceAvailable;
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

    public void SetSkillForSpace(string skillStr)
    {
        skillHub[0].SetActive(true);
        skillSpaceAvailable = skillStr;
        switch (skillStr)
        {
            case "Bomb":
                skill[0].SetActive(true);
                break;
            case "Dash":
                skill[1].SetActive(true);
                break;
            case "Invisible":
                skill[2].SetActive(true);
                break;
        }
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
