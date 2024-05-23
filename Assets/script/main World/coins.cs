using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class coins : MonoBehaviour
{
    [SerializeField] GameObject viscacha;// een reference naar de viscacha gameobject
    [SerializeField] TMP_Text CoinsText;//een tmp text met de naam coinstext
    public static int CoinsCount = 3;//maakt een coinscount aan en zet de value op 3
    // Start is called before the first frame update
    void Start()
    {
        viscacha.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinsCount != 0 && CoinsText != null)// checkt of coinscount niet 0 is en of coinstext niet leeg is
        {
            CoinsText.text = CoinsCount.ToString();// zet coinscount naar een string en zet dat op de text van coinstext
        }
        if(CoinsCount > 10)
        {
            viscacha.SetActive(true);
        }
    }
   public void addcoin()
    {
        CoinsCount++;//verhoogt coinscount met 1
    }
    public void add2coins()
    {
        CoinsCount += 2;//verhoogt coinscount met 2
    }
 
   
}

