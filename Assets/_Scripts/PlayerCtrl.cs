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
    [SerializeField] private GameManager gameManager;
    [SerializeField] private GameObject gameOver;
    [SerializeField] public SpaceSkillCtrl spaceSkillCtrl;
    Collider2D collider2D;
    Rigidbody2D rb;


    void Start()
    {
        isOnSite= true;
        rb = GetComponent<Rigidbody2D>();  
        collider2D= GetComponent<Collider2D>();
        spaceSkillCtrl= GetComponentInChildren<SpaceSkillCtrl>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DataManager.canDo == false) return;
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
        if (healthCtrl.GetHealth() <= 0)
        {
            DataManager.canDo = false;
            gameManager.Pause();
            gameOver.SetActive(true);
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
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy")) StartCoroutine(GetHurt(3f));
    }
    public IEnumerator GetHurt(float time)
    {
        DataManager.canAttackPlayer = false;
        animatorCtrl.GetComponentInChildren<Animator>().SetLayerWeight(1, 1);
        collider2D.enabled = false;
        yield return new WaitForSeconds(time);
        DataManager.canAttackPlayer = true;
        animatorCtrl.GetComponentInChildren<Animator>().SetLayerWeight(1, 0);
        collider2D.enabled = true;
    }
}
