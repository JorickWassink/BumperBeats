using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int totalScore;
    public int highScore;

    [SerializeField] TMP_Text scoreText;
    void Start()
    {
        totalScore = PlayerPrefs.GetInt("RhythRicoTempScore");
        highScore = PlayerPrefs.GetInt("RhythRicoHighScore");
    }

    void Update()
    {
        scoreText.SetText("SCORE: " + totalScore);

        if (totalScore >= highScore)
        {
            highScore = totalScore;
        }
    }
}
