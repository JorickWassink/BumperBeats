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
    }

    void Update()
    {
        scoreText.SetText("SCORE: " + totalScore);
        PlayerPrefs.SetInt("RhythRicoTempScore", totalScore);
    }
}
