using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class coins : MonoBehaviour
{
    [SerializeField] TMP_Text CoinsText;//een tmp text met de naam coinstext
    public static int CoinsCount = 3;//maakt een coinscount aan en zet de value op 3
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
        CoinsCount++;//verhoogt coinscount met 1
    }
    public void add2coins()
    {
        CoinsCount += 2;//verhoogt coinscount met 2
    }
 
   
}

