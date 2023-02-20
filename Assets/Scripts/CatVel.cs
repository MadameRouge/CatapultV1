using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatVel : MonoBehaviour
{
    public Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        rb.velocity = new Vector3(-5 * 10, rb.velocity.y, rb.velocity.z);
    }
}
