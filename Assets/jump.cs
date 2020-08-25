using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jump : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void JumpLeft()
    {
        //transform.localScale = new Vector3(-1f, 1f, 1f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(-100, 400);
    }

    public void JumpRight()
    {
        //transform.localScale = new Vector3(-1f, 1f, 1f);
        GetComponent<Rigidbody2D>().velocity = new Vector2(100, 400);
    }
}
