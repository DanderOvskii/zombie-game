using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class playerHP : MonoBehaviour
{
    public int healthplayer = 100;
    public int maxhealthplayer = 100;
    public GameObject deatheffect;
    public GameObject Enemy;
    public Enemy enemyreset;
    public Mony mony;
    public heathbar Healthbar;
    public TextMeshProUGUI hp;
    private bool isRegenHealth;
    public float healthRegenRate = 30f;
    public float delaytime = 5f;
    private bool regenincreese;
    public float regenstop;
    public int plushp;
   

   void Start()
   {
       healthplayer=maxhealthplayer;
       Healthbar.SetMaxHealth(maxhealthplayer);
       healthRegenRate=5;
       
   }

   void FixedUpdate()
   {
       hp.text=  healthplayer+"HP: " .ToString();
       if(healthplayer != maxhealthplayer && !isRegenHealth) {
              StartCoroutine(RegainHealthOverTime());
               }

        snellerregen();
        if(healthplayer==maxhealthplayer)
        {
            healthRegenRate=5;
        }

        if (healthRegenRate <= regenstop)
        {
            regenincreese = false;
        }

        if(healthplayer==maxhealthplayer)
        {
            healthRegenRate=5;
            regenincreese = true;
        }
        Healthbar.Sethealthy(healthplayer);
       
       
     
   }
    // Start is called before the first frame update
   public void TakeDamage(int damageEnemy)
   
   {
       healthplayer -= damageEnemy;
       

       if(healthplayer <= 0)
       {
           Die();


       }


   }

   void Die ()
   {
       Instantiate(deatheffect,transform.position,Quaternion.identity);
       Destroy(gameObject);
       Destroy(Enemy);
       enemyreset.healthreset();
      
   }

   private IEnumerator RegainHealthOverTime() {
     isRegenHealth = true;
     while (healthplayer < maxhealthplayer) {
         AdjustCurrentHealth (1);
         
         yield return new WaitForSeconds (healthRegenRate);
             }
     isRegenHealth = false;

   }
   public void AdjustCurrentHealth(int adj) {
         healthplayer += adj;
 
 
 
         if (healthplayer < 0)
                         healthplayer = 0;
 
         if (healthplayer > maxhealthplayer)
                         healthplayer = maxhealthplayer;
 
         if (maxhealthplayer < 1)
                         maxhealthplayer = 1;
 
         
 
 
         }

         void snellerregen()
         {
             if (healthplayer<=maxhealthplayer&& regenincreese==true)
             {
                healthRegenRate-=0.005f;
             }
         }

        public void HPplus()
         {
             healthRegenRate=1;
             maxhealthplayer+=plushp;

         }

         
       

}