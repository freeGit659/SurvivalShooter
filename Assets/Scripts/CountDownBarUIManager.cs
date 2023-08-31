using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownBarUIManager : MonoBehaviour
{
    [SerializeField] protected Image fill;
    [SerializeField] protected Text timeCountDownText;
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }
    public void UpdateBar(float currentValue, float maxValue)
    {
        fill.fillAmount = currentValue / maxValue;
        timeCountDownText.text = ((int)currentValue).ToString();
    }
    public void ActiveBar(bool status)
    {
        fill.gameObject.SetActive(status);
    }
}
