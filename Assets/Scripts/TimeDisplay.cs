using UnityEngine;
using TMPro;

public class TimeDisplay : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    private void Start()
    {
        // Retrieve the stored time from PlayerPrefs
        string finalTime = PlayerPrefs.GetString("Time");

        // Display the retrieved time
        timeText.text = finalTime;

    }
}