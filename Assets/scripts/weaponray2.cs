using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EZCameraShake;
using System.Collections;

public class weaponray2 : MonoBehaviour
{
    


    public Transform firepoint;
    public GameObject bulletprefab;
    public int kogels = 12; 
    public int kogelsrefill = 12;
    public float reloadspeed = 2f;
    public TextMeshProUGUI Kogelsover;
    
    public TextMeshProUGUI maggehoeveelheid;
    public float firerate = 15f;
    public float nextfire = 0f;

    public float reloadrate = 15f;
    public float nextreload = 0f;
    
    public recoiol21 recoioll;
    public recoiol21 recoiollcam;
    public float range = 100;
    public int damage;
    public Camera fpscam;
    public ParticleSystem muzle;
    public Animator animator;
    public bool canschoot = true;
    public GameObject sparks;
    public int kogelsplus;
    public int maggezijn;
    public bool laatstemagg = false;
    public int prijsmaggezijnINT = 50;
    public Mony mony;
   
    
    
    
    

   
   void start()
   {
       maggezijn=5;
   }
   
  
    
   

    // Update is called once per frame
    public void Update()
    {
        
        Kogelsover.text= "KOGELS OVER: " + kogels.ToString();
        maggehoeveelheid.text= "maggs OVER: " + maggezijn.ToString();
        if(Input.GetButton("Fire1") && kogels >0 && Time.time > nextfire && canschoot==true && laatstemagg==false)
        {
            shoot();
            recoioll.Fire();
            recoiollcam.Fire();
            shake.instance.shakecam();     
            nextfire = Time.time +1f/firerate;
            muzle.Play();
            FindObjectOfType<audiomeneger>().Play("gun shoot lazer");
        } 
        if(Input.GetButtonDown("Reload")&&maggezijn>0&& Time.time > nextreload)
        {
            animator.SetBool("reload", true);
            StartCoroutine (reload());
            canschoot=false;
            FindObjectOfType<audiomeneger>().Play("gun reload lazer"); 
            maggezijn -=1;
            nextreload = Time.time +1f/reloadrate;
        }
        if(maggezijn==0&&kogels==0)
        {
            laatstemagg=true;
        }
        else{
            laatstemagg=false;
        }
    }
    
    
    void shoot ()
    {
        
         
        Debug.DrawRay(fpscam.transform.position, fpscam.transform.forward,Color.yellow);
        
        
       RaycastHit hit;
       if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward,  out hit))
       {
           kogels -=1;

           Debug.Log(hit.transform.name);
           Enemy enemy =  hit.transform.GetComponent<Enemy>();
           if (enemy != null)
           {
               enemy.TakeDamage(damage);

           }
         GameObject impact =   Instantiate(bulletprefab, hit.point,Quaternion.LookRotation(hit.normal));
         Destroy(impact,6);

          GameObject sparceles =   Instantiate(sparks, hit.point,Quaternion.LookRotation(hit.normal));
         Destroy(sparceles,1);
       }
       
        
        
    

    }

    public IEnumerator reload()
    {
        yield return new WaitForSeconds(reloadspeed);
        kogels = kogelsrefill;
        animator.SetBool("reload", false);
        canschoot = true;
        
    }

   
    

    public void grotermagezine()
    {
        kogelsrefill += kogelsplus;
        kogels += kogelsplus;

    }

    

}