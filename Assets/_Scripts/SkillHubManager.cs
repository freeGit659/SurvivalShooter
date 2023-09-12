using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillHubManager : MonoBehaviour
{
    [SerializeField] protected InfomationSkillCtrl infomationSkillCtrl;
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    public void SetActiveInfomationPanel()
    {
        infomationSkillCtrl.gameObject.SetActive(true);
    }
    public void SetUnActiveInfomationPanel()
    {
        infomationSkillCtrl.gameObject.SetActive(false);
    }
    public void SetInfomationText(string content)
    {
        this.infomationSkillCtrl.skillInformation.text = content;
    }
    public void SetSkillCountDownText(float countDown)
    {
        this.infomationSkillCtrl.skillCountDown.text = "Hồi chiêu: " + countDown.ToString() + " giây";
    }
}
