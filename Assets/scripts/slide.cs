using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slide : MonoBehaviour
 {
     public Rigidbody rb;
     public float power;
    void Start()
    {
        rb.velocity=transform.forward*power;
        rb.AddForce(transform.up*power);


    }

    
     
 }
