using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class superbullet : MonoBehaviour
{
    private int score = 12 ;
    private weaponray Weaponray;
   

    void Update()
    {
        Weaponray = GameObject.FindObjectOfType<weaponray> ();
        
       

    }
    

    

    void OnCollisionEnter (Collision colahitinfo)
    {
        if(colahitinfo.gameObject.tag == "Player")
        {
        

        Weaponray.grotermagezine ();
        
        Debug.Log("hit");
        Destroy (gameObject);
        }
    }
}
