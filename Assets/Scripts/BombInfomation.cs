using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombInfomation : MonoBehaviour
{
    BombManager bombManager;
    public string infomation;
    void Start()
    {
        bombManager = GetComponentInParent<BombManager>();
    }

    void Update()
    {
        infomation = "Bomb: Đặt một quả bomb trên mặt đất. Quả bomb phát nổ sau " + bombManager.TimeSkillCountDownMax +" giây, đẩy lùi và gây " + bombManager.damage + " sát thương";
    }
}
