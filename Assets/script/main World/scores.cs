using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scores : MonoBehaviour
{
    public TMP_Text plincotext;
    public TMP_Text PinBallText;
    public static bool firstload;
    // Start is called before the first frame update
    void Start()
    {
        if (firstload == false)
        {
            PlayerPrefs.SetInt("plinco", 0);
            PlayerPrefs.SetInt("PinBallScore", 0);
            firstload = true;
        }
        if (plincotext != null)// checkt of plincohighscore niet leeg is
        {
            plincotext.text = PlayerPrefs.GetInt("plinco").ToString();// zet plincoscore naar een string en zet dat op de text van plincohihgscore
        }
        if(PinBallText != null)
        {
            PinBallText.text = PlayerPrefs.GetInt("PinBallScore").ToString();
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
