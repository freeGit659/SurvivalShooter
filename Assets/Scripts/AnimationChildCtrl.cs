using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Windows;

public class AnimationChildCtrl : MonoBehaviour
{
    [SerializeField] PlayerMoving playerMoving;
    Animator an;
    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (playerMoving.GetInput == Vector3.zero) an.SetBool("Walk", false);
        else an.SetBool("Walk", true);
    }
}
