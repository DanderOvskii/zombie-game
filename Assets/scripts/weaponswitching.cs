using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponswitching : MonoBehaviour
{
   public int selectedweapon = 0;
    void Start()
    {
        selectweapon();
    }

    // Update is called once per frame
    void Update()
    {
        int previouseselectedweapon = selectedweapon;

        if (Input.GetAxis("Mouse ScrollWheel")>0 )
        {
          if (selectedweapon >= transform.childCount -1)  
          selectedweapon=0;
          else
          selectedweapon++;
        }
        
         if (Input.GetAxis("Mouse ScrollWheel")<0)
        {
          if (selectedweapon <= 0)  
          selectedweapon=transform.childCount-1;
          else
          selectedweapon--;
        }

        if(previouseselectedweapon != selectedweapon)
        {
            selectweapon();
        }
    }

    void selectweapon()
    {
        int i = 0;
        foreach(Transform weapon in transform)
        {
            if (i==selectedweapon)
            weapon.gameObject.SetActive(true);
            else
            weapon.gameObject.SetActive(false);

            i++;

        }
    }
}
