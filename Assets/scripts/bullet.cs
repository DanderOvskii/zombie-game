using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public float power = 20f;
    public int damage = 25;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        
        rb.velocity = transform.up * -power;
        rb.useGravity = false;
        
        
    }

    // Update is called once per frame
   void OnTriggerEnter( Collider hitinfo){
       
           
       
       
       
       
       Enemy enemy = hitinfo.GetComponent<Enemy>();
       if(enemy !=null){

           enemy.TakeDamage(damage);
       }

       Destroy(gameObject);


   }
   void Update(){
       Destroy(gameObject,3);



   }
    void OnCollisionEnter (Collision drop)
   {
       rb.useGravity=true;

   }
   
       
   
}
