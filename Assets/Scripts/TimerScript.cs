using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class TimerScript : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    public string nextSceneName = "NextLevel";
    public string formattedTime;
    public bool isFinished;
    private static float startTime;
    private static string finalTime;
    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "Level 0")
        {
            float currentTime = Time.time - startTime;
            DisplayTime(currentTime);
            if (isFinished)
            {
                LoadNextLevel();
            }
        }
        else if(SceneManager.GetActiveScene().name == "Credits")
        {
            GameObject.Find("Time").GetComponent<TextMeshProUGUI>().text = formattedTime;
            isFinished = false;
            startTime = Time.time;
        }
        else if (SceneManager.GetActiveScene().name == "BadEnding")
        {
            GameObject.Find("Time").GetComponent<TextMeshProUGUI>().text = formattedTime;
            isFinished = false;
            startTime = Time.time;
        }
    }

    private void DisplayTime(float time)
    {
        int minutes = Mathf.FloorToInt(time / 60f);
        int seconds = Mathf.FloorToInt(time % 60f);
        int milliseconds = Mathf.FloorToInt((time * 1000) % 1000f);

        formattedTime = string.Format("{0:00}:{1:00}.{2:000}", minutes, seconds, milliseconds);
        timerText.text = formattedTime;
    }

    public void LoadNextLevel()
    {
        finalTime = formattedTime;
        SceneManager.LoadScene(nextSceneName);
    }
}