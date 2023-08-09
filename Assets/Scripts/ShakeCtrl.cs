using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeCtrl : MonoBehaviour
{
    [SerializeField] Animator animator;
    void Start()
    {
        animator = GetComponentInParent<Animator>();
    }

    
    void Update()
    {
        
    }
    public void LowShake()
    {
        animator.SetTrigger("Shake");
    }    
}
