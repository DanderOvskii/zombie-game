using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Mony : MonoBehaviour
{
    public int geld = 100;
    public bool deurknop = false;
    public Enemy enemy;
    public TextMeshProUGUI Geld;
    public int prijsmaggezijn;
    public int prijsmaggezijnbean;
    
    void Start()
    {
        prijsmaggezijn=50;
        prijsmaggezijnbean=50;
    }
    void Update()
    {
        Geld.text="GELD:"+geld.ToString();
    }
   

    public void gedplus(int geldplusvangrond)
    {
        geld += geldplusvangrond;


    }

    

}
