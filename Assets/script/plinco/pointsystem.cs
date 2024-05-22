using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    
    [SerializeField] PlincoGun plincoGun;
    [SerializeField] BulletsPlinco bulletsPlinco;
    [SerializeField] coins coins;
    public int score = 0;
    public TMP_Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        
    }

    // Update is called once per frame
   public void Update()
    {
        if (score != 0 && scoretext != null)// checkt of score niet 0 is en of scoretext niet leeg is
        {
            scoretext.text = score.ToString();// zet score naar een string en zet dat op de text van scoretext
        }
    }
    public void PlusBullet()
    {
        plincoGun.plusbullets();//runt de plusbullets method in de plincogun script
    }
    public void Plus5Points()
    {
        score = score + 5;// voegt 5 toe aan score
        scoretext.text = score.ToString();//zet de score om naar een string en zet het op de text van scoretext
    }
    public void Plus2Points()
    {
        score = score + 2;
        scoretext.text = score.ToString();
    }
    public void Plus1Point()
    {
        score = score + 1;
        scoretext.text = score.ToString();
  
    }
    public void Plus10Points()
    {
        score = score + 10;
        scoretext.text = score.ToString();
    }
    public void addcoin1()
    {
        coins.addcoin();//runt de addcoin method in coins script
    }
    public void addcoins2()
    {
        coins.add2coins();//runt de add2coins method in coins script
    }
}

