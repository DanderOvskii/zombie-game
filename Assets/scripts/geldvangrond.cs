using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geldvangrond : MonoBehaviour
{
    private int geldplusvangrond = 10;
    private Mony mony;
    // Start is called before the first frame update
    void Start()
    {
        mony = GameObject.FindObjectOfType<Mony> ();
        

    }

    void OnCollisionEnter (Collision geldhitinfo)
    {
        if(geldhitinfo.gameObject.tag == "Player")
        {
        

        mony.gedplus (geldplusvangrond);
        Debug.Log("hit");
        Destroy (gameObject);
        }
    }
}
