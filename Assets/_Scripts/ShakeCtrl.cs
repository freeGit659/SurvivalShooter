using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCtrl : MonoBehaviour
{
    [SerializeField] Animator animator;
    public static bool isShake;
    void Start()
    {
        animator = GetComponentInParent<Animator>();
        isShake = false;
    }

    
    void Update()
    {
        if (isShake)
        {
            LowShake();
            isShake = false;
        }
    }
    public void LowShake()
    {
        animator.SetTrigger("Shake");
    }    
}
