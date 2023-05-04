using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shaking : MonoBehaviour
{
    public float duration = 1.0f;
    public float magnitude = 0.1f;

    private Vector3 originalPosition;
    private float elapsed = 0.0f;

    void Start()
    {
        originalPosition = transform.localPosition;
    }

    void Update()
    {
        if (elapsed < duration)
        {
            float x = originalPosition.x + Random.Range(-1f, 1f) * magnitude;
            float y = originalPosition.y + Random.Range(-1f, 1f) * magnitude;
            float z = originalPosition.z + Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = new Vector3(x, y, z);

            //elapsed += Time.deltaTime;
        }
        else
        {
            transform.localPosition = originalPosition;
        }
    }
}
