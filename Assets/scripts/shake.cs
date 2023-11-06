using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class shake : MonoBehaviour
{
    public static shake instance;
    public Transform cameraTransform;
    private Vector3 originalcamirapos;

    public float chakeduration;
    public float chakeamaunt;
    public float reset;
    private bool canshake = false;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this);
        }
        else
        {
            Destroy(this);
        }
    }

    void Start ()
    {
        originalcamirapos = cameraTransform.localPosition;
    }
    void Update()
    {
        if(chakeduration >0)
        {

        
        cameraTransform.localPosition=originalcamirapos + Random.insideUnitSphere * chakeamaunt;
        chakeduration -= Time.deltaTime;
        }
        else
        {
            chakeduration = 0f;
            cameraTransform.localPosition = originalcamirapos;
        }
    }

    public void shakecam()
    {
        canshake = true;
        chakeduration = reset;

    }

}