using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EZCameraShake;
using System.Collections;

public class weaponray : MonoBehaviour
{
    


    public Transform firepoint;
    public GameObject bulletprefab;
    public int kogels = 12; 
    public int kogelsrefill = 12;
    public float reloadspeed = 2f;
    public TextMeshProUGUI Kogelsover;
    public float firerate = 15f;
    public float nextfire = 0f;
    
    public recoiol21 recoioll;
    public recoiol21 recoiollcam;
    public float range = 100;
    public int damage;
    public Camera fpscam;
    public ParticleSystem muzle;
    public ParticleSystem smoke;
    public Animator animator;
    public bool canschoot = true;
    public AudioClip gun;
    public AudioClip gunreload;
    public GameObject sparks;
    public float timer ;
    public Enemy enemy;
    public int kogelsplus;
    
    
    
    
    

   

   
  
    
   

    // Update is called once per frame
    public void Update()
    {
        Kogelsover.text= "KOGELS OVER: " + kogels.ToString();
        if(Input.GetButton("Fire1") && kogels >0 && Time.time > nextfire && canschoot==true)
        {
            shoot();
            recoioll.Fire();
            recoiollcam.Fire();
            shake.instance.shakecam();     
            nextfire = Time.time +1f/firerate;
            muzle.Play();
            timer=5;
            
            FindObjectOfType<audiomeneger>().Play("gun shoot");
        } 
        if(Input.GetButtonDown("Reload"))
        {
            animator.SetBool("reload", true);
            StartCoroutine (reload());
            canschoot=false;
            FindObjectOfType<audiomeneger>().Play("gun reload"); 
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

    void FixedUpdate()
    {
        timer -= 0.5f;
        if(timer==0f)
        {
            smoke.Play();

        }
    }

    

    


}