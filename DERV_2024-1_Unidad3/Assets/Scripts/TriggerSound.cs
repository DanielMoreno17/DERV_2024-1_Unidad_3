using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class TriggerSound : MonoBehaviour
{
    public AudioSource source;
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        source.Play(); 
        source.loop = true;
    }

    private void OnTriggerExit(Collider other)
    {
        source.loop= false;
    }
}
