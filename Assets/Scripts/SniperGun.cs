using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SniperGun : WeaponCtrl
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject muzzle;
    [SerializeField] Transform bulletMagazine;
    [SerializeField] AudioSource shootingSound;
    [SerializeField] ShakeCtrl shakeCtrl;

    private float timeFire;
    [SerializeField] Transform[] firePosition;
    private float _timeFire;
    void Start()
    {
        shootingSound = GetComponentInChildren<AudioSource>();
        timeFire = 3*(1/statsCtrl.fireSpeed);
        statsCtrl.fireDamage = 100;
    }
    void Update()
    {
        timeFire = 3*(1/statsCtrl.fireSpeed);
        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 lookDir = mousePos - transform.position;
        float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

        Quaternion rotation = Quaternion.Euler(0f, 0f, angle);
        transform.rotation = rotation;

        if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
            transform.localScale = new Vector3(1, -1, 0);
        else transform.localScale = new Vector3(1, 1, 0);

        _timeFire -= Time.deltaTime;
        if (Input.GetMouseButton(0) && _timeFire < 0)
        {
            DefaultFire(this.bullet, this.firePosition, this.bulletMagazine,
                this.muzzle, this.transform, this.shootingSound, this.shakeCtrl);
            _timeFire = timeFire;
        }
    }
}
