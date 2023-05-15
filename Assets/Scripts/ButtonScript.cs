using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript : MonoBehaviour
{
    public float scaleAmount = 1.1f;
    public Vector3 originalScale;
    public string Level0; // Name of the next scene to load

    private void Start()
    {
        originalScale = transform.localScale;
    }

    private void OnMouseDown()
    {
        transform.localScale *= scaleAmount;
    }

    private void OnMouseUp()
    {
        transform.localScale = originalScale;

        // Load the next scene
        SceneManager.LoadScene("Level 0");
    }
}