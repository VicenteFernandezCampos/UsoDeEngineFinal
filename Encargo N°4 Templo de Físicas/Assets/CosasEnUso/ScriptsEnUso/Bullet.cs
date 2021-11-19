using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float forward = 1.2f;
    public float up = 5f;
    Rigidbody rb;

    void Start()
    {
        Destroy(gameObject, 2);
        rb = GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * forward);
        rb.AddForce(transform.up * up);
    }

    
    
}
