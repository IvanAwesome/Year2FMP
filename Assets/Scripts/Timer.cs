using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Timer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float startTime;
    private bool timerRunning = false;

    private void Start()
    {
        // Start the timer when the scene loads
        StartTimer();
    } 

    private void Update()
    {
        // Update the timer display if the timer is running
        if (timerRunning)
        {
            float currentTime = Time.time - startTime;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");

            timerText.text = "Time: " + minutes + ":" + seconds;
        }

    }

    public void StartTimer()
    {
        // Start the timer
        startTime = Time.time;
        timerRunning = true;
    }

    public void StopTimer()
    {
        // Stop the timer
        timerRunning = false;
    }

    public void ShowTime()
    {
        // Display the final time in the next scene
        PlayerPrefs.SetString("Time", timerText.text);
        float currentTime = Time.time - startTime; 
    }
}