using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCtrl : MonoBehaviour
{
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    protected virtual void BulletFire(Rigidbody2D rb, Transform transform, float speed, GameObject gameObject, float lifeTime)
    {
        Destroy(gameObject, lifeTime);
        rb = GetComponent<Rigidbody2D>();
        rb.AddForce(transform.right * speed, ForceMode2D.Impulse);
    }
}
