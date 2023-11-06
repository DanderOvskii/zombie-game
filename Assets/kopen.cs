using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class kopen : MonoBehaviour
{
    public Canvas selectie;
    public look kijken;
    public weaponray wapen;
   

    void Start()
    {
        selectie.gameObject.SetActive(false);

    }

    void OnCollisionEnter(Collision mechine)
    {
        if(mechine.gameObject.tag == "Player")
        {
            selectie.gameObject.SetActive(true);
            wapen.gameObject.SetActive(false);
            kijken.sensetifity=0;
            Cursor.lockState = CursorLockMode.Confined;
        

       
        }
        
        
    }

    
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetButton("kopen"))
        {
            selectie.gameObject.SetActive(false);
            wapen.gameObject.SetActive(true);
            kijken.sensetifity=100;
            Cursor.lockState = CursorLockMode.Locked;
        

       
        }
        
    }

    
    
}
