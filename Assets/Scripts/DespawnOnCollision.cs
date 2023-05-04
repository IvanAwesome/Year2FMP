using UnityEngine;

public class DespawnOnCollision : MonoBehaviour
{
    public Transform otherObject;
    public float despawnDistance = 2f;

    private void Update()
    {
        if (Vector3.Distance(transform.position, otherObject.position) < despawnDistance)
        {
            Destroy(gameObject);
        }
    }
}