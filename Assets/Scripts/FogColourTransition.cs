using UnityEngine;

public class FogColourTransition : MonoBehaviour
{
    public Color targetColor;
    public float transitionDuration = 5f;

    private Color initialColor;
    private float elapsedTime;

    private void Start()
    {
        initialColor = RenderSettings.fogColor;
        elapsedTime = 0f;
    }

    private void Update()
    {
        if (elapsedTime < transitionDuration)
        {
            // Calculate the color transition over time
            float t = elapsedTime / transitionDuration;
            Color currentColor = Color.Lerp(initialColor, targetColor, t);

            // Update the fog color
            RenderSettings.fogColor = currentColor;

            // Increase the elapsed time
            elapsedTime += Time.deltaTime;
        }
    }
}