using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class scores : MonoBehaviour
{
    public TMP_Text plincohighscore;
    int Plincoscore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
         Plincoscore = PlayerPrefs.GetInt("plincoscore", 0);
        if (plincohighscore != null)// checkt of plincohihgscore niet leeg is
        {
            plincohighscore.text = Plincoscore.ToString();// zet plincoscore naar een string en zet dat op de text van plincohihgscore
        }
    }
}