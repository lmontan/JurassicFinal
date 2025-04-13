using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundOnTriggerEnter : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource audioSource1;

    void Start()
    {

    }

    void OnTriggerEnter(Collider other)
    {

        audioSource.Play();
        audioSource.Play();
    }
}
