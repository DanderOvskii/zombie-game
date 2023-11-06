using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    
    

    
    public int healthenemy = 100 ;
    


    GameObject enemyprfab;
    public Enemy enemy;
    public Rigidbody rb;

    
    


    
     public GameObject geld;
     public GameObject medkit;
     public GameObject death;
    

    

    

    

    
   
    // Start is called before the first frame update
   public void TakeDamage(int damage)
   
   {
       healthenemy -= damage;

       if(healthenemy <= 0)
       {
           
           
           die();
           

           
           


       }


   }
   public Transform draopspawn;
   
   int randomobject = 100;

   void die ()
   {
       randomobject = Random.Range(1,101);

       if(randomobject>=11 && randomobject <=100)
       {
           Instantiate(geld,draopspawn.position,Quaternion.Euler(-90f,0f,0f));

       }
       
       
       

       if(randomobject>=1 && randomobject <=10)
       {
           Instantiate(medkit,draopspawn.position,Quaternion.Euler(90f,0f,0f));

       }

       if(randomobject>=1 && randomobject <=100)
       {
           Instantiate(death,draopspawn.position,Quaternion.Euler(90f,0f,0f));

       }
       
       
       
       Destroy(gameObject);

       
       

   }

   

   public void hpup()
   {
       healthenemy += 10;
       Debug.Log("hp is up");


   }

   public void healthreset()
   {
       healthenemy = 100;
       


   }
   
}

   
  
