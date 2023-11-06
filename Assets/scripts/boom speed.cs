using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boomspeed : MonoBehaviour
{

     Animator animationboom;
    float langsaam = 0.5f;
    float snell = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
       animationboom = gameObject.GetComponent<Animator>();
       
       animationboom.speed=(Random.Range(langsaam,snell));
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
