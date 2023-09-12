using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputNameCtrl : MonoBehaviour
{
    [SerializeField]InputField name;
    [SerializeField] GameObject InputField;
    [SerializeField] CardManager cardManager;
    public string playerName;
    private void Awake()
    {
        InputField.SetActive(true);
        DataManager.canDo = false;

        Time.timeScale = 0f;
    }
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Submit()
    {
        playerName = name.text;
        InputField.SetActive(false);
        cardManager.CardCalled();
    }
}
