using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class magezijnenplusbeangun : MonoBehaviour
{
    public beangunray beangun;
    public TextMeshProUGUI prijsmaggezijn;
    public Mony mony;
    
    
    public void magezijnkopenbean()
    {
        
        if(mony.geld>=mony.prijsmaggezijnbean)
        {
          beangun.maggezijn +=5;
        
          mony.geld-=mony.prijsmaggezijnbean;
          mony.prijsmaggezijnbean+=50;
        }
    }
       
        
        
    

    void Update()
    {
        prijsmaggezijn.text= "magezijn $ " + mony.prijsmaggezijnbean.ToString();
    }
}
