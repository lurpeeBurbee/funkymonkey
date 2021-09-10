using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSounds : MonoBehaviour
{
    public AudioSource buttonSounds;
    public AudioClip buttonClip;

    void Start()
    {
       
    }
    public void ButtonSound()
    {
 buttonSounds = GetComponent<AudioSource>();
            buttonSounds.PlayOneShot(buttonClip);
           
    }
    void Update()
    {
        
    }
}
