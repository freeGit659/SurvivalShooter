using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonCtrl : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private void OnEnable()
    {
        transform.localScale = Vector3.one;
    }
    private void Start()
    {
        
    }
    void Update()
    {

    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        transform.localScale = new Vector3(1.3f, 1.3f, 1);
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        transform.localScale = Vector3.one;
    }
}
