using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject muzzle;
    [SerializeField] Transform bulletMagazine;
    [SerializeField] Transform firePos;
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
        GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity, bulletMagazine);
        Instantiate(muzzle, firePos.position, transform.rotation, transform);

        Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
    }
}
