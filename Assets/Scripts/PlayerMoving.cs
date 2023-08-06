using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : PlayerCtrl
{
    [SerializeField] protected float speed;
    [SerializeField] PlayerCtrl playerCtrl;
    [SerializeField] Animator animatorCtrl;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    private Vector3 input;
    void Start()
    {
        
    }

    void Update()
    {
        if (!playerCtrl.IsOnSite) return;
        input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        playerCtrl.transform.position += input * speed * Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0f) playerCtrl.transform.localScale = new Vector3(1,1,1);
        else if (Input.GetAxis("Horizontal") < 0f) playerCtrl.transform.localScale = new Vector3(-1, 1, 1);
        if (input == Vector3.zero) animatorCtrl.SetBool("Walk", false);
        else animatorCtrl.SetBool("Walk", true);
    }
}
