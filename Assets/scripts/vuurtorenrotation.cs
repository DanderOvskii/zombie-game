﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vuurtorenrotation : MonoBehaviour
{
    public int _rotationSpeed = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        transform.Rotate (0, _rotationSpeed * Time.deltaTime, 0,0);
        
    }
}
