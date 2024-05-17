using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class pointsystem : MonoBehaviour
{
    [SerializeField] PlincoGun plincoGun;
    [SerializeField] BulletsPlinco bulletsPlinco;
    public int score;
    public TMP_Text scoretext;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        score = 0;
    }

    // Update is called once per frame
   public void Update()
    {
        if (score != 0 && scoretext != null)// checkt of score niet 0 is en of scoretext niet leeg is
        {
            scoretext.text = score.ToString();// zet score naar een string en zet dat op de text van scoretext
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "1 ball")
        {
            plincoGun.plusbullet();
            bulletsPlinco.Destroyobject();
        }
        if (collision.gameObject.name == "5 score")
        {
            print("5");
            score += 5;
            bulletsPlinco.Destroyobject();
        }
        if (collision.gameObject.name == "2 score")
        {
            print("2");
            score += 2;
            bulletsPlinco.Destroyobject();
        }
        if (collision.gameObject.name == "1 score")
        {
            print("1");
            score ++;
            bulletsPlinco.Destroyobject();
        }
        if ((collision.gameObject.name == "10 score"))
        {
            print("10");
            score += 10;
            bulletsPlinco.Destroyobject();
        }
    }
}
