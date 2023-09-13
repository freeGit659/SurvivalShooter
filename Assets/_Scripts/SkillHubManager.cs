using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillHubManager : MonoBehaviour
{
    [SerializeField] protected InfomationSkillHubCtrl infomationSkillHubCtrl;
    [SerializeField] protected SkilInfomation skillInfomation;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void SetActiveInfomationPanel()
    {
        infomationSkillHubCtrl.gameObject.SetActive(true);
    }
    public void SetUnActiveInfomationPanel()
    {
        infomationSkillHubCtrl.gameObject.SetActive(false);
    }
    public void SetInfomationText()
    {
        this.infomationSkillHubCtrl.skillInformation.text = skillInfomation.infomation;
    }
    public void SetSkillCountDownText()
    {
        this.infomationSkillHubCtrl.skillCountDown.text = "Hồi chiêu: " + skillInfomation.timeCountDownInfomation.ToString() + " giây";
    }
    public void SetIndexSkill( int skillIndex)
    {
        switch (skillIndex)
        {
            case 0:
                this.skillInfomation.SetInfomationForBomb();
                break;
            case 1:
                this.skillInfomation.SetInfomationForDash();
                break;
            case 2:
                this.skillInfomation.SetInfomationForInvisble();
                break;
        }
    }
}
