using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class coins : MonoBehaviour
{
    [SerializeField] TMP_Text CoinsText;
    [SerializeField] int CoinsCount;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinsCount2 != 0 && CoinsText != null)// checkt of coinscount niet 0 is en of coinstext niet leeg is
        {
            CoinsText.text = CoinsCount2.ToString();// zet coinscount naar een string en zet dat op de text van coinstext
        }
        if(Input.GetKeyDown(KeyCode.E)) 
        {
            addcoin();
        }
    }
    void addcoin()
    {
        CoinsCount2++;
    }
    public int CoinsCount2
    {
        get { return CoinsCount; } //krijgt de coinsCount
        set { CoinsCount = value; } // zet coinscount naar de value
    }
}

