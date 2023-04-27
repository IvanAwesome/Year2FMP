using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterInteraction : MonoBehaviour
{
    // Public variable for the interaction distance
    public float interactionDistance = 10f;

    // Update is called once per frame
    void Update()
    {
        // Check if the player presses the interact button
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            // Check for any objects within the interaction distance
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, interactionDistance);

            // Loop through each hit collider
            foreach (Collider hitCollider in hitColliders)
            {
                // Check if the hit collider has an interactable script attached
                Interactable interactable = hitCollider.GetComponent<Interactable>();

                if (interactable != null)
                {
                    // Call the interact function on the interactable object
                    interactable.Interact();
                }
            }
        }
    }
}
