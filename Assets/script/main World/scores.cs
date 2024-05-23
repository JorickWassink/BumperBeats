using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class scores : MonoBehaviour
{
    public TMP_Text plincohighscore;
    int Plincoscore;
    private void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
       
        
    }


    // Update is called once per frame
    void Update()
    {
        Plincoscore = PlayerPrefs.GetInt("plincoscore");
        if (plincohighscore != null)// checkt of plincohihgscore niet leeg is
        {
            plincohighscore.text = Plincoscore.ToString();// zet plincoscore naar een string en zet dat op de text van plincohihgscore
        }
    }
}
