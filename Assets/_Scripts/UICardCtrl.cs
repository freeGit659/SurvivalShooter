using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICardCtrl : MonoBehaviour
{
    [SerializeField] Text textInfo;
    [SerializeField] Image image;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetInfo(Sprite image, string text)
    {
        this.textInfo.text = text;
        this.image.sprite = image;
    }
}
