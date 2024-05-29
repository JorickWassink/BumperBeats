using TMPro;
using UnityEngine;

public class ScoreKeeper : MonoBehaviour
{
    public int totalScore; //public int voor totale score dat wordt bij gehouden
    public int highScore; //public int voor de Highscore

    [SerializeField] TMP_Text scoreText;

    void Start()
    {
        totalScore = PlayerPrefs.GetInt("RhythRicoTempScore"); //pakt de waarde wat in deze specefieke PlayerPref zit, namelijk de score op dit moment
        highScore = PlayerPrefs.GetInt("RhythRicoHighScore"); //zelfde als ^deze hierboven maar dan voor de Highscore
    }

    void Update()
    {
        scoreText.SetText("SCORE: " + totalScore);

        if (totalScore >= highScore) //checkt of score hoger is dan de highscore
        {
            highScore = totalScore; //zet de waarde van de highscore
        }
    }
}
