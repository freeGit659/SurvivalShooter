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
    [SerializeField] Collider2D collider2D;
    [SerializeField] GameObject blood;
    private float currentHP;
    Animator an;

    private bool isDeath;
    void Start()
    {
        player = GameObject.FindWithTag("Player").transform;
        collider2D = GetComponent<Collider2D>();
        timeFollow = 0;
        an = GetComponent<Animator>();
        isDeath = false;
        currentHP = maxHP + 10*DataManager.level;
        blood.SetActive(false);
    }

    void Update()
    {
        if (isDeath) return;
        if (DataManager.statusDayNight == "day") maxSpeed = 0.3f;
        else if (DataManager.statusDayNight == "night") maxSpeed = 0.5f;
        Death();
        if (!DataManager.canAttackPlayer)
        {
            an.SetBool("Follow", false);
            return;
        }
        an.SetBool("Follow", true);
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
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (isDeath) return;
        if (collision.gameObject.CompareTag("Bullet"))
        {
            currentHP -= StatsCtrl.FireDamage;
            StartCoroutine(GetHurt());
        }   
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (isDeath) return;
        if (collision.gameObject.CompareTag("Player"))
        {
            DataManager.playerHealth -= 1;
        }
        if (collision.gameObject.CompareTag("Boom"))
        {
            currentHP -= currentHP;
            StartCoroutine(GetHurt());
        }
    }
    private void Death()
    {
        if (currentHP > 0) return;
        isDeath = true;
        collider2D.enabled = false;
        DataManager.score += 1;
        an.SetBool("Death", true);
        Destroy(gameObject, 1f);
    }
    private IEnumerator GetHurt()
    {
        blood.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        blood.SetActive(false);
    }
}
