using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int highscore;

    public Text scoreText;
    public Text highscoreText;

    void Awake ()
    {
        //scoreText = GetComponent<Text>();
        //score = 0;

        //highscoreText = GetComponent<Text>();
        //highscore = 0;
    }

    private void Start()
    {
        Load();
    }

    void Update ()
    {
        //scoreText.text = "Score: " + score;
        //highscoreText.text = "Highscore: " + highscore;

        scoreText.text = score.ToString();
        highscoreText.text = highscore.ToString();

        if (score > highscore)
        {
            highscore = score;
            Save();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        Save();
    }

    public void SubstractScore(int amount)
    {
        score -= amount;
        Save();
    }

    public void Save()
    {
        PlayerPrefs.SetInt("score", score);
        PlayerPrefs.SetInt("highscore", highscore);
    }

    public void Load()
    {
        //score = PlayerPrefs.GetInt("score");
        highscore = PlayerPrefs.GetInt("highscore");
    }
}
