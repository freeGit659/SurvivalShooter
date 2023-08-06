using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorCtrl : MonoBehaviour
{
    [SerializeField] private Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        animator = GetComponentInChildren<Animator>();
    }
}
