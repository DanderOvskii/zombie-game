using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crouche : MonoBehaviour
 {
     
     public float crouchespeed = 6;
     public playrmovement move;
     public Animator animator;
    
    

    
     // Start is called before the first frame update
     void Start()
     {
         

        
         
     }
 
     // Update is called once per frame
     void Update()
     {
         if (Input.GetKeyDown(KeyCode.C))
         {
         
             Crouch();
             animator.SetBool("crouche", true);
         }
         else if (Input.GetKeyUp(KeyCode.C))
         {
             GoUp();
             animator.SetBool("crouche", false);
         }




             
     }
 
     void Crouch()
     {
         
         move.normalspeed=crouchespeed;
         move.runspeed=crouchespeed;
         
         
     }
 
     void GoUp()
     {
         
        
         move.normalspeed=12;
         move.runspeed=20;
         
         
         
     }

    
     
 }
