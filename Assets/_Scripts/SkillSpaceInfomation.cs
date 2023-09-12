using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillSpaceInfomation : MonoBehaviour
{
    SpaceSkillCtrl spaceSkillCtrl;
    [SerializeField] BombManager bombManager;
    [SerializeField] DashManager dashManager;
    [SerializeField] InvisibleManager invisibleManager;
    public string infomation;
    public float timeCountDownInfomation;
    void Start()
    {
        spaceSkillCtrl = GetComponentInParent<SpaceSkillCtrl>();
    }

    void Update()
    {
        switch (spaceSkillCtrl.skillSpaceAvailable)
        {
            case "Bomb":
                SetInfomationForBomb();
                break;
            case "Dash":
                SetInfomationForDash();
                break;
            case "Invisible":
                SetInfomationForInvisble();
                break;
        }
    }
    void SetInfomationForBomb()
    {
        infomation = "Bomb: Đặt một quả bomb trên mặt đất. Quả bomb phát nổ sau 2 giây, đẩy lùi và gây " + bombManager.damage + " sát thương";
        timeCountDownInfomation = bombManager.TimeSkillCountDownMax;
    }
    void SetInfomationForDash()
    {
        infomation = "Lướt: Lướt một khoảng cách nhất định theo hướng côn trỏ chuột. Tốc độ và khoảng cách lướt tỉ lệ thuận với tốc độ di chuyển";
        timeCountDownInfomation = dashManager.TimeSkillCountDownMax;
    }
    void SetInfomationForInvisble()
    {
        infomation = "Tàng hình: Tàng hình và miễn nhiễm sát thương trong " + invisibleManager.TimeInvesible + ".";
        timeCountDownInfomation = invisibleManager.TimeSkillCountDownMax;
    }
}
