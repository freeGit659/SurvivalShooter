using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardManager : MonoBehaviour
{
    [SerializeField] GameObject cardCanvas;
    [SerializeField] CardProcessed cardProcessed;
    public DataManager dataManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AfterSelect()
    {
        cardCanvas.SetActive(false);
        Time.timeScale = 1.0f;
        
    }
    public void CardCalled()
    {
        Time.timeScale = 0f;
        cardCanvas.SetActive(true);
    }
}
