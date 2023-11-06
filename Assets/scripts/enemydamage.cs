using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydamage : MonoBehaviour
{
   
    public int damageEnemy = 25;
     public float attacerate = 15f;
    public float nextattec = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void OnTriggerEnter( Collider hitinfo){
       playerHP player = hitinfo.GetComponent<playerHP>();
       if(player !=null&&Time.time > nextattec){

           player.TakeDamage(damageEnemy);
           nextattec = Time.time +1f/attacerate;
       }

       


   }
   void Update(){
       



   }
   
}
