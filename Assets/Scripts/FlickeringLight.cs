using UnityEngine;

public class FlickeringLight : MonoBehaviour
{
    public Light targetLight;
    public float minIntensity = 0.2f;
    public float maxIntensity = 1f;
    public float flickerSpeed = 1f;

    private float randomOffset;

    private void Start()
    {
        randomOffset = Random.value; // Randomize the offset for each light
    }

    private void Update()
    {
        float intensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PerlinNoise(Time.time * flickerSpeed + randomOffset, 0f));
        targetLight.intensity = intensity;
    }
}