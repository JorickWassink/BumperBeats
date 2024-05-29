using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scores : MonoBehaviour
{
    [SerializeField] GameObject pinballviscacha;
    [SerializeField] GameObject plincoviscacha;
    [SerializeField] GameObject breakoutviscacha;
    [SerializeField] GameObject rythemviscacha;
    public TMP_Text plincotext;
    public TMP_Text PinBallText;
    public TMP_Text rythemText;
    public TMP_Text breakoutText;
    public static bool firstload;
    int plincoscore;
    int pinballscore;
    int breakoutscore;
    int rythemscore;
    // Start is called before the first frame update
    void Start()
    {
        pinballviscacha.SetActive(false);
        plincoviscacha.SetActive(false);
        breakoutviscacha.SetActive(false);
        rythemviscacha.SetActive(false);
        if (firstload == false)
        {
            PlayerPrefs.SetInt("plinco", 0);
            PlayerPrefs.SetInt("PinBallScore", 0);
            PlayerPrefs.SetInt("RhythRicoHighScore", 0);
            PlayerPrefs.SetInt("highscoreBreakout", 0);
            firstload = true;
        }
        if (plincotext != null)// checkt of plincohighscore niet leeg is
        {
            plincotext.text = PlayerPrefs.GetInt("plinco").ToString();// zet plincoscore naar een string en zet dat op de text van plincohihgscore
            plincoscore = PlayerPrefs.GetInt("plinco");//zet de int van plinco op plincscore
            if(plincoscore > 50)
            {
                plincoviscacha.SetActive (true);
            }
        }
        if(PinBallText != null)
        {
            PinBallText.text = PlayerPrefs.GetInt("PinBallScore").ToString();
            pinballscore = PlayerPrefs.GetInt("PinBallScore");
            if(pinballscore > 5000)
            {
                pinballviscacha.SetActive (true);
            }
        }
        if(rythemText != null)
        {
            rythemText.text = PlayerPrefs.GetInt("RhythRicoTempScore").ToString();
            rythemscore = PlayerPrefs.GetInt("RhythRicoTempScore");
            if(rythemscore > 5000)
            {
                rythemviscacha.SetActive (true);
            }
        }
        if(breakoutText != null)
        {
            breakoutText.text = PlayerPrefs.GetInt("highscoreBreakout").ToString();
            breakoutscore = PlayerPrefs.GetInt("highscoreBreakout");
            if(rythemscore > 50)
            {
                breakoutviscacha.SetActive (true);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
