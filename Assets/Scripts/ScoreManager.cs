using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public int score;
    public Text scoreText;

    // Static instance variable
    public static ScoreManager instance;

    private void Awake()
    {
        // Set the static instance variable to this instance
        instance = this;
    }

    public void UpdateScore()
    {
        score++;
        scoreText.text = "Score: " + score.ToString();

        if (score == 1)
        {
            // Call the GameOver method from the static instance variable
            instance.GameOver();
        }
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
    }
}