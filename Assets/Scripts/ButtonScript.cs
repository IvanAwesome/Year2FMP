using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class ButtonScript : MonoBehaviour
{
    public float scaleAmount = 1.1f;
    public Vector3 originalScale;
    public int LevelToLoad; // Name of the next scene to load
    public TextMeshProUGUI buttonText;

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
        SceneManager.LoadScene(LevelToLoad);
        PlayerCoin.totalcoin = 0;
    }
}