using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleTriggerBone : MonoBehaviour
{

    public ParticleSystem particleSystem;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bone") // Or any tag that matches your player or VR controller
        {
            // Disable emission

            // Optionally, stop the system (this might not be needed if you only want to prevent new particles)
            particleSystem.Stop();
        }
    }
}
