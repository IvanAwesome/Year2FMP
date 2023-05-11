using UnityEngine;

public class Coin : MonoBehaviour
{
    public int value = 1;
    public GameObject coinEffect;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //ScoreManager.instance.ChangeScore(value);
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}