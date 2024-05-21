using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BulletsPlinco : MonoBehaviour
{
    [SerializeField] pointsystem pt;
    [SerializeField] coins coins;
    [SerializeField] PlincoSound ps;
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bouncePlinco")
        {
            ps.PlayBoing();
        }
        if (collision.gameObject.name == "1 ball")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.PlusBullet();
        }
        if (collision.gameObject.name == "5 score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus5Points();
        }
        if (collision.gameObject.name == "2 score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus2Points();
        }
        if (collision.gameObject.name == "one score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus1Point();
        }
        if ((collision.gameObject.name == "10 score"))
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus10Points();
        }
        if(((collision.gameObject.name == "end background")))
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            
        }
        if(collision.gameObject.name == "1 coins")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            print("1 coin");
            pt.addcoin1();
        }
        if(collision.gameObject.name == "2 coins")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            print("2 coins");
            pt.addcoins2();
        }
    }

}
