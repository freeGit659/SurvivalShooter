using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
}
