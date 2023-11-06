using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuopen : MonoBehaviour
{
    public Canvas selectie;
    public look kijken;
    public weaponray wapen;
    public int wegofterug =1;
    // Start is called before the first frame update
    void Start()
    {
        selectie.gameObject.SetActive(false);
        wegofterug =1;
        
    }

   

    // Update is called once per frame
    void Update()
    {   
       

        
        if(Input.GetButtonUp("menu")&& wegofterug ==2)
        {
            selectie.gameObject.SetActive(false);
            wapen.gameObject.SetActive(true);
            kijken.sensetifity=100;
            Cursor.lockState = CursorLockMode.Locked;
            wegofterug =1;
        

       
        }

         if(Input.GetButtonDown("menu")&& wegofterug ==1 )
        {
            selectie.gameObject.SetActive(true);
            wapen.gameObject.SetActive(false);
            kijken.sensetifity=0;
            Cursor.lockState = CursorLockMode.Confined;
            wegofterug =2;
        

       
        }
        
        
    }
}
