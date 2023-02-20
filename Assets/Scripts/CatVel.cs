using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatVel : MonoBehaviour
{
    public Rigidbody rb;
    
    void Start()
    {
        float VelRandom = Random.Range(-5, -15);
        rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(VelRandom * 10, rb.velocity.y, rb.velocity.z);
    }

    void Update()
    {
    }
}
