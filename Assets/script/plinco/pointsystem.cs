using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    
    [SerializeField] PlincoGun plincoGun;
    [SerializeField] BulletsPlinco bulletsPlinco;
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
    public void plusBullet()
    {
        plincoGun.plusbullet();

    }
    public void Plus5Points()
    {
        print("5");
        score = score + 5;
        scoretext.text = score.ToString();
    }
    public void Plus2Points()
    {
        print("2");
        score = score + 2;
        scoretext.text = score.ToString();
    }
    public void Plus1Point()
    {
        print("1");
        score = score + 1;
        scoretext.text = score.ToString();
  
    }
    public void Plus10Points()
    {
        print("10");
        score = score + 10;
        scoretext.text = score.ToString();
    }
}

