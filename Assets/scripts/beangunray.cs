using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EZCameraShake;
using System.Collections;

public class beangunray : MonoBehaviour
{
    


    public Transform firepoint;
    public GameObject bulletprefab;
    public GameObject sparks;
    public GameObject boonblik1;
    public GameObject boonblik2;
    public GameObject boonblik3;

    
    

    public TextMeshProUGUI Kogelsover;
    public TextMeshProUGUI maggehoeveelheid;

    public float firerate = 15f;
    public float nextfire = 0f;
    public float reloadspeed = 2f;
    
    public recoiol21 recoioll;
    public recoiol21 recoiollcam;

    public float range = 100;
    public int damage;
    public Camera fpscam;
    public ParticleSystem muzle;
    public ParticleSystem boonuitblik;
    public ParticleSystem boonuitblik2;
    public ParticleSystem boonuitblik3;

    public Animator animatorreload;
    public Animator animatorreload2;
    
    public bool canschoot = true;
    public int kogelsplus;
    public int maggezijn;
    public int kogels = 12; 
    public int kogelsrefill = 12;
    public int prijsmaggezijnINT = 50;
    public int _rotationSpeed = 30;
    public int _rotationSpeedlangzaam = 30;
    public bool laatstemagg = false;
    
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
            boonuitblik.Play();
            boonuitblik2.Play();
            boonuitblik3.Play();
            FindObjectOfType<audiomeneger>().Play("gun shoot lazer");
            
            boonblik1.transform.Rotate (0,0, _rotationSpeed * Time.deltaTime);
            boonblik2.transform.Rotate (0,0, -_rotationSpeed * Time.deltaTime);
            boonblik3.transform.Rotate (0,0, _rotationSpeed * Time.deltaTime);
        } 
        else
        {
            boonblik1.transform.Rotate (0,0, _rotationSpeedlangzaam * Time.deltaTime);
            boonblik2.transform.Rotate (0,0, -_rotationSpeedlangzaam * Time.deltaTime);
            boonblik3.transform.Rotate (0,0, _rotationSpeedlangzaam * Time.deltaTime);
           

        }
        if(Input.GetButtonDown("Reload")&&maggezijn>0)
        {
            animatorreload.SetBool("reload", true);
            animatorreload2.SetBool("reload", true);
            StartCoroutine (reload());
            canschoot=false;
            FindObjectOfType<audiomeneger>().Play("gun reload lazer"); 
            maggezijn -=1;
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
        animatorreload.SetBool("reload", false);
        animatorreload2.SetBool("reload", false);
        canschoot = true;
        
    }

   
    

    public void grotermagezine()
    {
        kogelsrefill += kogelsplus;
        kogels += kogelsplus;

    }

    
    

}