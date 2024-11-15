using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pointsystem : MonoBehaviour
{

    [SerializeField] PlincoGun plincoGun;
    [SerializeField] BulletsPlinco bulletsPlinco;
    [SerializeField] coins coins;
    [SerializeField] GameObject viscacha;
    public int score = 0;
    public int highscore;
    public static bool firstload;
    public TMP_Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        highscore = PlayerPrefs.GetInt("plinco");//zet plinco int playerpref op highscore int
        if (firstload == false)//chekt off de bool firstload op false is
        {
            firstload = true;//zet firstload op true
        }
        viscacha.SetActive(false);//zet de viscacha gameobject op false zodat het niet gezien wordt

    }

    // Update is called once per frame
    public void Update()
    {
        if (score != 0 && scoretext != null)// checkt of score niet 0 is en of scoretext niet leeg is
        {
            scoretext.text = score.ToString();// zet score naar een string en zet dat op de text van scoretext
        }
        if (score > 15)//checkt of de score hoger dan 15 is
        {
            viscacha.SetActive(true);
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
    public void savescore()
    {
        if (score > highscore)//checkt of score hoger is dan highscore
        {
            highscore = score;//zet highscore gelijk met score
            PlayerPrefs.SetInt("plinco", highscore);//saved highscore op de plinco int playerpref
        }
        else
        {
            PlayerPrefs.SetInt("plinco", highscore);
        }
    }
}
