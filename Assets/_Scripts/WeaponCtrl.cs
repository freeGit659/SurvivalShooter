using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponCtrl : MonoBehaviour
{
    [SerializeField] GameObject[] weapons;
    public StatsCtrl statsCtrl;
    protected float fireSpeedDefault;
    void Start()
    {

    }
    void Update()
    {

    }
    protected virtual IEnumerator DefaultFire(GameObject bullet, Transform[] firePosition, Transform bulletMagazine, 
        GameObject muzzle, Transform gunTransfrom, AudioSource shootingSound, ShakeCtrl shakeCtrl )
    {
        muzzle.SetActive(true);
        shootingSound.Play();

        shakeCtrl.LowShake();
        foreach(Transform pos in firePosition)
        {
            GameObject bulletTmp = Instantiate(bullet, pos.position, pos.rotation, bulletMagazine);
        }
        yield return new WaitForSeconds(0.2f);
        muzzle.SetActive(false);
    }
    public void ActiveWeapon(string input)
    {
            switch(input)
            {
            case "rifle":
                weapons[0].SetActive(true);
                weapons[1].SetActive(false);
                weapons[2].SetActive(false);
                statsCtrl.fireSpeed = 2f;
                break;
            case "shootgun":
                weapons[0].SetActive(false);
                weapons[1].SetActive(true);
                weapons[2].SetActive(false);
                statsCtrl.fireSpeed = 1f;
                break;
            case "sniper":
                weapons[0].SetActive(false);
                weapons[1].SetActive(false);
                weapons[2].SetActive(true);
                statsCtrl.fireSpeed = 0.5f;
                break;
        }
    }
}
