using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class coins : MonoBehaviour
{
    [SerializeField] TMP_Text CoinsText;
    public static int CoinsCount = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinsCount != 0 && CoinsText != null)// checkt of coinscount niet 0 is en of coinstext niet leeg is
        {
            CoinsText.text = CoinsCount.ToString();// zet coinscount naar een string en zet dat op de text van coinstext
        }
    }
   public void addcoin()
    {
        CoinsCount++;
    }
    public void add2coins()
    {
        CoinsCount += 2;
    }
 
   
}

