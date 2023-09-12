using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;
using UnityEngine.UI;

public class SunCtrl : MonoBehaviour
{
    [SerializeField] Animator an;
    [SerializeField] Light2DManager lightManager;
    [SerializeField] Text text;

    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public IEnumerator SunRise()
    {
        text.text = "Ban ngày lũ Zombie có vẻ mệt mỏi.\r\nHãy cố gắng chuẩn bị trước khi \r\nmàn đêm chết chóc ập tới";
        lightManager.waiting = true;
        Debug.Log("rise");
        an.SetInteger("Status", 2);
        yield return new WaitForSeconds(3f);
        DataManager.canAttackPlayer = true;
        lightManager.waiting = false;
        gameObject.SetActive(false);
    }
    public IEnumerator SunDown()
    {
        text.text = "Ban đêm lũ Zombie khoẻ hơn ban ngày.\r\nHãy cẩn thận.";
        lightManager.waiting = true;
        Debug.Log("down");
        an.SetInteger("Status", -2);
        yield return new WaitForSeconds(3f);
        DataManager.canAttackPlayer = true;
        lightManager.waiting = false;
        gameObject.SetActive(false); 
    }
}
