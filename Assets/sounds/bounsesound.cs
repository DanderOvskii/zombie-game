using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bounsesound : MonoBehaviour
{
    public AudioClip shell;
     
    public AudioSource Audio;
    AudioSource Audioreload;
    public float volume;
    // Start is called before the first frame update
   void OnCollisionEnter()
   {
       Audio = GetComponent<AudioSource>();
       Audio.PlayOneShot(shell , volume);

   }
}
