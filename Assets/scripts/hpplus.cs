using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hpplus : MonoBehaviour
{
    private playerHP hpplayer;
    private heathbar hpbar;
    // Start is called before the first frame update
    void Start()
    {
        hpplayer = GameObject.FindObjectOfType<playerHP> ();
        hpbar = GameObject.FindObjectOfType<heathbar> ();
        

    }

     void OnCollisionEnter (Collision medkithit)
    {
        if(medkithit.gameObject.tag == "Player")
        {
        

        hpplayer.HPplus();
        hpbar.healthbarplus();
        Debug.Log("hit");
        Destroy (gameObject);
        }
    }
}
