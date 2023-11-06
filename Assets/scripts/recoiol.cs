using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class recoiol : MonoBehaviour
{
    public Vector3 recoiolup;
    Vector3 originals;
    // Start is called before the first frame update
    void Start()
    {
       originals = transform.localEulerAngles; 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1"))
        addrecoiol();
        
        else if (Input.GetButtonUp("Fire1"))
        addrecoiolstop();

        
        
    }
    private void addrecoiol()
    {
        transform.localEulerAngles+=recoiolup;
    }
    
     private void addrecoiolstop()
    {
        transform.localEulerAngles=originals;
    }

   


}
