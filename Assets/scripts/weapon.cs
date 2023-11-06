
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using EZCameraShake;
using System.Collections;

public class weapon : MonoBehaviour
{
    


    public Transform firepoint;
    public GameObject bulletprefab;
    public int kogels = 12; 
    public int kogelsrefill = 12;
    public float reloadspeed = 2f;
    public TextMeshProUGUI Kogelsover;
    private float firerate = 0.1f;
    private float nextfire = 0f;
    GameObject bulletprefabclone;
    public recoiol21 recoioll;
    public Camera Camera;
    
    

   

   
  
    
   

    // Update is called once per frame
    void Update()
    {
         Kogelsover.text= "KOGELS OVER: " + kogels.ToString();

         if(Input.GetButton("Fire1") && kogels >0 && Time.time > nextfire)
         {

            shoot();
            recoioll.Fire();
            CameraShaker.Instance.ShakeOnce(0.5f,1, .1f,1f);
            kogels -=1;

            
            
        } 

        if(Input.GetButtonDown("Reload"))
        {
            StartCoroutine (reload());
        }

        
       
    }
    
    
    void shoot ()
    {
        
        
        nextfire = Time.time + firerate;
        bulletprefabclone= Instantiate(bulletprefab, firepoint.position, firepoint.rotation  ) as GameObject;
        
        
    

    }

    public IEnumerator reload()
    {
        yield return new WaitForSeconds(reloadspeed);
        kogels = kogelsrefill;
    }

   
    

    public void grotermagezine(int score)
    {
        kogelsrefill += score;
        kogels += score;

    }

}
