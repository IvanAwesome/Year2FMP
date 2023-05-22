using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider col)
    {
      if(col.CompareTag("Player"))
        {
            SceneManager.LoadScene("BadEnding");
            PlayerCoin.totalcoin = 0;
        }
    }
}
