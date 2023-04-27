using UnityEngine;

public class SpotlightController : MonoBehaviour
{
    public Transform player;

    void Update()
    {
        if (player != null)
        {
            // Use LookAt to make the spotlight face the player
            transform.LookAt(player);
        }
    }
}