using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deur : MonoBehaviour
{
    public Mony mony;
    public int prijsdeur;
    public Animator animator;
    public bool eenkeerkopen = false;
    
    
    void start()
        {
            eenkeerkopen = false;
            

        }
    
    void OnCollisionEnter (Collision deur)
    {
        if (deur.gameObject.tag == "Player")
        {
        mony.deurknop = true;
        
        
        
        if(mony.geld >= prijsdeur && mony.deurknop == true && eenkeerkopen==true )
        {
            animator.SetBool("dearopen", true);
            mony.geld -= prijsdeur;
            eenkeerkopen = false;
            Destroy(gameObject,2);
            
            


        }
        }
        

    }
}
