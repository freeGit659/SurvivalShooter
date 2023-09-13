using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillActivatedCtrl : MonoBehaviour
{
    [SerializeField] GameObject image;
    [SerializeField] Sprite[] icon;
    [SerializeField] SkillCtrl skillCtrl;
    public int index;
    private float time;
    void Start()
    {
        time = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        if (!image.activeSelf) return;
        time-= Time.deltaTime;
        if (time <= 0f)
        {
            time = 1.5f;
            image.gameObject.SetActive(false);
        }
    }
    public void SetIcon()
    {
        image.gameObject.SetActive(true);
        this.image.GetComponent<Image>().sprite = this.icon[skillCtrl.indexIcon]; 
    }

}
