using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class heathbar : MonoBehaviour
{
    public Slider slider;
    public int HPplus;

    public void SetMaxHealth(int health)
    {
        slider.maxValue=health;
        slider.value=health;

    }

    public void Sethealthy(int health)
    {
        slider.value=health;

    }
    

    // Update is called once per frame
    void Update()
    {
        
    }

    public void healthbarplus()
    {
        slider.maxValue+=HPplus;
    }
}
