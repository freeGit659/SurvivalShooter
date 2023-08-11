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

    [SerializeField] private float gravitation;
    public AnimatorCtrl animatorCtrl;
    [SerializeField] private GameObject weaponManager;
    public HealthCtr healthCtrl;
    [SerializeField] private DataManager DataManager;
    Rigidbody2D rb;
 
    void Start()
    {
        isOnSite= true;
        rb = GetComponent<Rigidbody2D>();  
    }

    // Update is called once per frame
    void Update()
    {
        if (weaponManager.activeSelf)
        {
            animatorCtrl.transform.GetChild(0).gameObject.SetActive(false);
            animatorCtrl.transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            animatorCtrl.transform.GetChild(1).gameObject.SetActive(false);
            animatorCtrl.transform.GetChild(0).gameObject.SetActive(true);
        }
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
