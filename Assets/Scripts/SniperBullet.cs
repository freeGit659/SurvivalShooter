using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperBullet : BulletCtrl
{
    [SerializeField] float lifeTime;
    [SerializeField] float speed;
    //[SerializeField] WeaponCtrl weaponCtrl;
    Rigidbody2D rb;
    void Start()
    {
        BulletFire(this.rb, this.transform, this.speed, this.gameObject, this.lifeTime);
    }
}
