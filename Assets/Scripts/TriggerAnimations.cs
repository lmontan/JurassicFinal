using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimations : MonoBehaviour
{
    public string enterAnimationTrigger = "PlayAnimation"; // Animation to play on trigger enter
    public string exitAnimationTrigger = "StopAnimation";  // Animation to play on trigger exit
    public Animator animator; // Reference to the Animator component

    private void Start()
    {
        if (animator == null)
        {
            animator = GetComponent<Animator>(); // Get the Animator if not assigned
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {

            if (animator != null)
            {
                animator.SetTrigger(enterAnimationTrigger);
            }
            else
            {
                Debug.LogWarning("Animator component is missing on " + gameObject.name);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (animator != null)
        {
            animator.SetTrigger(exitAnimationTrigger);
        }
        else
        {
            Debug.LogWarning("Animator component is missing on " + gameObject.name);
        }
    }
}
