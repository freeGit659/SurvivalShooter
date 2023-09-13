using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class SkillInfomationHubChildren : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{ 
    [SerializeField] public int skillIndex;
    [SerializeField] SkillHubManager skillHubManager;
    private void Start()
    {
        skillHubManager = GetComponentInParent<SkillHubManager>();
    }
    void Update()
    {
        
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        skillHubManager.SetIndexSkill(skillIndex);
        skillHubManager.SetActiveInfomationPanel();
        skillHubManager.SetInfomationText();
        skillHubManager.SetSkillCountDownText();
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        skillHubManager.SetUnActiveInfomationPanel();
    }
}
