using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCtrl : MonoBehaviour
{
    [SerializeField] private Transform taget;
    private Vector3 offset = new Vector3(0, 0, -10);
    private float smoothTime = 0.25f;
    private Vector3 velocity = Vector3.zero;
    private void Start()
    {

    }
    void Update()
    {
        Vector3 tagetPosition = taget.position + offset + new Vector3 ( 0, -5 , 0);
        transform.position = Vector3.SmoothDamp(transform.position, tagetPosition, ref velocity, smoothTime);
        transform.position = new Vector3(
            Mathf.Clamp(taget.position.x, -165f, 65f),
            Mathf.Clamp(taget.position.y, -83, 115),
                transform.position.z);
        
    }
}
