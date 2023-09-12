using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillSpaceHubManager : SkillHubManager, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] protected SkillSpaceInfomation skillSpaceInfomation;
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        this.SetActiveInfomationPanel();
        this.SetInfomationText(this.skillSpaceInfomation.infomation);
        this.SetSkillCountDownText(this.skillSpaceInfomation.timeCountDownInfomation);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        this.SetUnActiveInfomationPanel();
    }
}
