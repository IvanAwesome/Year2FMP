using UnityEngine;
using TMPro;

public class PlayerCoin : MonoBehaviour
{
    //public int value = 1;
    public GameObject coinEffect;
    public static int totalcoin;
    public TMP_Text text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            //ScoreManager.instance.ChangeScore(value);
            Instantiate(coinEffect, transform.position, Quaternion.identity);
            totalcoin++;
            Debug.Log(totalcoin);
            text.text = totalcoin.ToString();
            Destroy(gameObject);
        }
    }
}