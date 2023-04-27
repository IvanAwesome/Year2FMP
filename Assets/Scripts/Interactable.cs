using UnityEngine;

public class Interactable : MonoBehaviour
{
    public bool canInteract = true; // Allows the player to interact with this object

    public virtual void Interact()
    {
        Debug.Log("Interacting with " + gameObject.name);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && canInteract)
        {
            Interact();
        }
    }
}
