using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playrmovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed;
    public float runspeed = 50f;
    public float normalspeed = 12f;
    public float grafity = -9f;
    public float jumpheight = 3f;

    public Transform goundCheck;
    public float grounddictence = 0.4f;
    public LayerMask groundmask;

    Vector3 velocity;

    bool isGroundet;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        isGroundet = Physics.CheckSphere(goundCheck.position, grounddictence, groundmask);

        if(isGroundet && velocity.y < 0) 
        {
            velocity.y = -2f;


        }
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        
        controller.Move(move * speed * Time.deltaTime);

        if(Input.GetButtonDown("Jump") && isGroundet)
        {
            velocity.y = Mathf.Sqrt(jumpheight * -2f * grafity);


        }

        velocity.y += grafity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        //run

        if(Input.GetButton ("Run"))
        {
            speed = runspeed;
            

        }else{

            speed = normalspeed;
        }

       
       


        

        
        
    }
}
