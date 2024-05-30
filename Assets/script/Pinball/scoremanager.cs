using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    [SerializeField] TMP_Text score; // zorgt ervoor dat je een waarde kan geven aan de var in de inspector maar dat de var nogsteeds private blijft
    int scoreInt = 0;
    int highscore = 0; // maakt een var aan en geeft het meteen een waarde
    void Update() // runt elke frame
    {
        score.text = scoreInt.ToString(); // veranderdt de text van het text object naar de waarde van een int geconvert naar een string
        highscore = PlayerPrefs.GetInt("PinballScore"); // geeft de waarde van een var in de playerprefs
        if (scoreInt >= highscore) PlayerPrefs.SetInt("PinBallScore", scoreInt); // als de conditie klopt geef dan een var in playerprefs een waarde
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bumper")) scoreInt += 25; // als de conditie klopt verhoog dan de int met in dit geval 25 
        if (collision.gameObject.CompareTag("Wall")) scoreInt += 50;
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("PowerUp")) scoreInt += 10;
    }
}

