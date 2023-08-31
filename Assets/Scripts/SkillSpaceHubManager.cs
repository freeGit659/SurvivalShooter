using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillSpaceHubManager : SkillHubManager, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] protected BombInfomation bombInfomation;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        this.SetActiveInfomationPanel();
        this.SetInfomationText(this.bombInfomation.infomation);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        this.SetUnActiveInfomationPanel();
    }
}
