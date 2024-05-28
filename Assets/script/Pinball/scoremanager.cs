using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    int scoreInt = 0;
    int highscore = 0;
    void Update()
    {
        score.text = scoreInt.ToString();
        highscore = PlayerPrefs.GetInt("PinballScore");
        if (scoreInt >= highscore) PlayerPrefs.SetInt("PinBallScore", scoreInt);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bumper")) scoreInt += 25;
        if (collision.gameObject.CompareTag("Wall")) scoreInt += 50;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp")) scoreInt += 10;
    }
}

