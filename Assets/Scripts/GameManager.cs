using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject logo;
    public GameObject endScreen;
    public TMP_Text scoreText;
    public TMP_Text personalBest;
    public TMP_Text endScore;
    public int score;
    int highscore;


    void Update()
    {
        scoreText.text = score.ToString();
    }

    void Start()
    {
        highscore = PlayerPrefs.GetInt("highscore");
        print(highscore);
    }

    public void StartGame()
    {
        logo.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    public void EndGame()
    {
        endScreen.SetActive(true);
        scoreText.gameObject.SetActive(true);
        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", score);
        }
        endScore.text = score.ToString();
        personalBest.text = highscore.ToString();
    }
}
