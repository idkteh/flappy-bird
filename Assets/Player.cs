using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float velocity = 2.4f;

    private Rigidbody2D rigidbody;


    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            rigidbody.velocity = Vector2.up * velocity;
        }
        
    }
}
