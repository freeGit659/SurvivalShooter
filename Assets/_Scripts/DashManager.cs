using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashManager : SpaceSkillCtrl
{
    [SerializeField] float dashSpeed;
    [SerializeField] float dashDuration;
    [SerializeField] float dashTime;
    [SerializeField] Transform player;
    [SerializeField] DashSkillCountDownCtrl dashSkillCountDown;
    [SerializeField] PlayerMoving playerMoving;
    Rigidbody2D rb;
    Vector3 playerScreenPosition;
    Vector3 mouseScreenPosition;

    Vector3 playerToMouseVector;
    private bool canDash;
    private bool isDashing;

    void Start()
    {
        canDash = true;
        isDashing= false;
        rb = player.GetComponent<Rigidbody2D>();
        dashSkillCountDown = GetComponentInChildren<DashSkillCountDownCtrl>();
        icon.SetActive(true);
    }

    
    void Update()
    {
        dashSpeed = 50 + playerMoving.Speed;
        dashDuration = playerMoving.Speed * 0.01f;
        playerScreenPosition = Camera.main.WorldToScreenPoint(player.transform.position);
        mouseScreenPosition = Input.mousePosition;

        playerToMouseVector = (mouseScreenPosition - playerScreenPosition).normalized;
        if (!DataManager.canDo) return;
        this.timeSkillcountDownCurrent -= Time.deltaTime;
        this.TimeCountDownLimited();
        this.useSkill();
        
    }

    IEnumerator Dash()
    {
   
        isDashing= true;
        rb.velocity = new Vector2(dashSpeed * playerToMouseVector.x, dashSpeed * playerToMouseVector.y);
        yield return new WaitForSeconds(dashDuration);
        rb.velocity = new Vector2(0, 0);
        
        yield return new WaitForSeconds(this.timeSkillCountDownMax); 
        isDashing = false;
    }
    public override void useSkill()
    {
        if (Input.GetKeyDown(KeyCode.Space) && !isDashing)
        {
            this.StartCoroutine(Dash());
            this.dashSkillCountDown.ActiveBar(true);
            this.timeSkillcountDownCurrent = this.timeSkillCountDownMax;
        }
    }
    public override void TimeCountDownLimited()
    {
        if (this.timeSkillcountDownCurrent <= 0)
        {
            this.timeSkillcountDownCurrent = 0;
            this.dashSkillCountDown.ActiveBar(false);
        }
    }
}
