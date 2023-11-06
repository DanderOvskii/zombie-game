using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onoftrigger : MonoBehaviour
{
   
    public GameObject lazer;
    public Mony mony;

    void Start()
    {
        lazer.SetActive(false);
    }
    

    
    
    

    void OnCollisionEnter (Collision geldhitinfo)
    {
        if(geldhitinfo.gameObject.tag == "Player" && mony.geld >=50)
        {
           lazer.SetActive(true);
           mony.geld -=50;
           Destroy(gameObject);
        

        
        }
    }
   
   
}
