using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTriggerEgg : MonoBehaviour
{
   
    public ParticleSystem particleSystem;

    [SerializeField]
    private AudioSource correctSound;

    [SerializeField]
    private AudioSource incorrectSound;


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Egg") // Or any tag that matches your player or VR controller
        {
            ObjectManager.Instance.UpdateList(other.gameObject);

            // Optionally, stop the system (this might not be needed if you only want to prevent new particles)
            particleSystem.Stop();
            correctSound.Play();
        }
        if (other.tag != "Egg")
        {
            incorrectSound.Play();
        }
    }
}

