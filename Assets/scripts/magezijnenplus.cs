using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class magezijnenplus : MonoBehaviour
{
    public weaponray2 lazergun;
    public TextMeshProUGUI prijsmaggezijn;
    public Mony mony;
    
    
    public void magezijnkopen()
    {

         if(mony.geld>=mony.prijsmaggezijn)
        {
            
            lazergun.maggezijn +=5;
        
            mony.geld-=mony.prijsmaggezijn;
            mony.prijsmaggezijn+=50;
        }
        
    }

    void Update()
    {
        prijsmaggezijn.text= "magezijn $ " + mony.prijsmaggezijn.ToString();
    }
}
