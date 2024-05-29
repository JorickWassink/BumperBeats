using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int totalScore;
    public int highScore;

    [SerializeField] TMP_Text scoreText;
    [SerializeField] TMP_Text scoreText2;
    void Start()
    {
        totalScore = PlayerPrefs.GetInt("RhythRicoTempScore");
        highScore = PlayerPrefs.GetInt("RhythRicoHighScore");
    }

    void Update()
    {
        scoreText2.SetText("HIGHSCORE: " + highScore);
        scoreText.SetText("SCORE: " + totalScore);

        if (totalScore >= highScore)
        {
            highScore = totalScore;
        }
    }
}
