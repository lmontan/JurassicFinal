using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTrigger : MonoBehaviour
{
    public ParticleSystem particleSystem;

    [SerializeField]
    private AudioSource correctSound;

    [SerializeField]
    private AudioSource incorrectSound;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Amber") // Or any tag that matches your player or VR controller
        {
            ObjectManager.Instance.UpdateList(other.gameObject);
            
            // Optionally, stop the system (this might not be needed if you only want to prevent new particles)
            particleSystem.Stop();
            correctSound.Play();
        }
        if (other.tag != "Amber")
        {
            incorrectSound.Play(); 
        }
    }

    void OnTriggerExit(Collider other)
    {
       /* if (other.tag == "Player")
        {
            // Enable emission (optional, if you want to turn it back on)
            
             // Optionally, play the system (if you stopped it previously)
            particleSystem.Play();
        }*/
    }
}