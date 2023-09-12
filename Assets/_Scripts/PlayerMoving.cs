using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoving : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] PlayerCtrl playerCtrl;
    public AnimatorCtrl animatorCtrl;
    public float Speed
    {
        get { return speed; }
        set { speed = value; }
    }
    private Vector3 input;
    public Vector3 GetInput
    {
        get { return input; }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (!playerCtrl.IsOnSite) return;
        input = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0).normalized;
        playerCtrl.transform.position += input * speed * Time.deltaTime;
        if (Input.GetAxis("Horizontal") > 0f) animatorCtrl.transform.localScale = new Vector3(1,1,1);
        else if (Input.GetAxis("Horizontal") < 0f) animatorCtrl.transform.localScale = new Vector3(-1, 1, 1);
        playerCtrl.transform.position = new Vector2(
            Mathf.Clamp(playerCtrl.transform.position.x, -217f, 115f),
            Mathf.Clamp(playerCtrl.transform.position.y, -103, 149));
    }
}
