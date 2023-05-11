using UnityEngine;
using System.Collections.Generic;

public class SlendermanItemCollection : MonoBehaviour
{
    public float interactionDistance = 3f;
    public AudioClip collectSound;
    public List<string> collectedItemTags;

    private List<GameObject> itemsInRange = new List<GameObject>();
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void Update()
    {
        foreach (GameObject item in itemsInRange)
        {
            if (item == null) continue;
            float distanceToItem = Vector3.Distance(transform.position, item.transform.position);
            if (distanceToItem < interactionDistance)
            {
                CollectItem(item);
            }
        }
    }

    private void OnTriggerEnter(Collider Coin)
    {
        if (Coin.CompareTag("Coin") && !collectedItemTags.Contains(Coin.tag))
        {
            itemsInRange.Add(Coin.gameObject);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Coin") && itemsInRange.Contains(other.gameObject))
        {
            itemsInRange.Remove(other.gameObject);
        }
    }

    private void CollectItem(GameObject item)
    {
        audioSource.PlayOneShot(collectSound);
        collectedItemTags.Add(item.tag);
        item.SetActive(false);
    }
}