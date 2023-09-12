using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class SunCtrl : MonoBehaviour
{
    [SerializeField] Animator an;

    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public IEnumerator SunRise()
    {
        Debug.Log("rise");
        an.SetInteger("Status", 2);
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
        DataManager.canAttackPlayer = true;
    }
    public IEnumerator SunDown()
    {
        Debug.Log("down");
        an.SetInteger("Status", -2);
        yield return new WaitForSeconds(1.5f);
        gameObject.SetActive(false);
        DataManager.canAttackPlayer = true;
    }
}
