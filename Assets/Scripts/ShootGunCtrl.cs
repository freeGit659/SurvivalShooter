using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootGunCtrl : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject muzzle;
    [SerializeField] Transform bulletMagazine;
    [SerializeField] Transform firePos1;
    [SerializeField] Transform firePos2;
    [SerializeField] Transform firePos3;
    [SerializeField] AudioSource shootingSound;
    [SerializeField] ShakeCtrl shakeCtrl;

    [SerializeField] float timeFire;
    [SerializeField] float bulletForce;
    private float _timeFire;
    void Start()
    {
        shootingSound = GetComponentInChildren<AudioSource>();
    }
    void Update()
    {
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
            FireBullet();
        }
    }
    private void FireBullet()
    {
        shootingSound.Play();

        shakeCtrl.LowShake();

        _timeFire = timeFire;
        GameObject bulletTmp1 = Instantiate(bullet, firePos1.position, firePos1.rotation, bulletMagazine);
        GameObject bulletTmp2 = Instantiate(bullet, firePos1.position, firePos2.rotation, bulletMagazine);
        GameObject bulletTmp3 = Instantiate(bullet, firePos1.position, firePos3.rotation, bulletMagazine);
        Instantiate(muzzle, firePos2.position, transform.rotation, transform);
    }
}
