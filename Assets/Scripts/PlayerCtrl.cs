using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private bool isOnSite;
    public bool IsOnSite
    {
        get { return isOnSite; }
    }

    [SerializeField]  private float gravitation;
    Rigidbody2D rb;
    SpriteRenderer sr;
    // Start is called before the first frame update
    void Start()
    {
        isOnSite= true;
        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
        sr.enabled = false;
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.gameObject.CompareTag("Border"))
        {
            isOnSite = false;
            rb.gravityScale = 2;
        }
    }
}
