using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    [SerializeField] float lifeTime;
    //[SerializeField] WeaponCtrl weaponCtrl;
    Rigidbody2D rb;
    void Start()
    {
        Destroy(gameObject, lifeTime);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * 100, ForceMode2D.Impulse);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
