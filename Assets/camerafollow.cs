using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    private Transform playerTransform;
    public float smooth = 0.125f;
    public float offset = -20;
    void Start()
    {
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        
    }

    void LateUpdate()
    {
        Vector3 temp = transform.position;
        
        temp.x = playerTransform.position.x;
        //transform.position = temp;
        temp.y= playerTransform.position.y+offset;
        Vector3 smoothed = Vector3.Lerp(transform.position, temp, smooth);
        transform.position = temp;


    }
}
