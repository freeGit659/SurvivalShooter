using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCtrl : MonoBehaviour
{
    [SerializeField] Transform player;
    private float speed;
    [SerializeField] float maxSpeed;
    [SerializeField] float timeFollow;
    [SerializeField] float maxHP;
    private float currentHP;
    Animator an;

    private bool isDeath;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        timeFollow = Random.Range(1f,2f);
        an = GetComponent<Animator>();
        isDeath = false;
        currentHP = maxHP;
    }

    void Update()
    {
        if (isDeath) return;
        Vector3 ranPos = new Vector3(Random.Range(0f, 3f), Random.Range(0f, 3f), 0);
        transform.position += (player.position - transform.position - ranPos) * Random.Range(0f, maxSpeed) * Time.deltaTime;
        if (timeFollow <= 0)
        {
            Vector3 direction = player.position - transform.position;
            if (direction.x > 0)
                transform.localScale = new Vector3(1, 1, 0);
            else transform.localScale = new Vector3(-1, 1, 0);
            timeFollow = Random.Range(1f, 2f);
        }
        timeFollow -= Time.deltaTime;
        Death();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDeath) return;
        if (collision.gameObject.CompareTag("Bullet"))
        {
            currentHP -= StatsCtrl.FireDamage;
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDeath) return;
        if (collision.gameObject.CompareTag("Player"))
        {
            DataManager.playerHealth -= 1;
        }
    }
    private void Death()
    {
        if (currentHP > 0) return;
        isDeath = true;
        DataManager.score += 1;
        an.SetBool("Death", true);
        Destroy(gameObject, 1f);
    }
}
