using UnityEngine;
using UnityEngine.SceneManagement;

public class Collectable : MonoBehaviour
{
    public int collectableValue = 1;
    public AudioClip collectSound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //ScoreManager.instance.ChangeScore(collectableValue);
            AudioSource.PlayClipAtPoint(collectSound, transform.position);
            gameObject.SetActive(false); // Deactivate the collectable object
            CheckIfAllCollected(); // Check if all collectables have been picked up
        }
    }

    private void CheckIfAllCollected()
    {
        // Find all active collectables in the scene
        Collectable[] collectables = FindObjectsOfType<Collectable>();
        bool allCollected = true;

        // Check if all collectables have been picked up
        foreach (Collectable collectable in collectables)
        {
            if (collectable.gameObject.activeSelf)
            {
                allCollected = false;
                break;
            }
        }

        // If all collectables have been picked up, load the next scene
        if (allCollected)
        {
            SceneManager.LoadScene("Credits");
        }
    }
}