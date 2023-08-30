using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoomCtr : MonoBehaviour
{
    [SerializeField] Animator an;
    [SerializeField] Collider2D col;
    [SerializeField] AudioSource audio;
    void Start()
    {
        an = GetComponent<Animator>();
        col= GetComponent<Collider2D>();
        audio= GetComponent<AudioSource>();
        StartCoroutine(Explosion());
    }

    void Update()
    {
        
    }
    IEnumerator Explosion()
    {
        yield return new WaitForSeconds(1f);
        col.enabled = true;
        audio.Play();
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }
}
