using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class BulletsPlinco : MonoBehaviour
{
    [SerializeField] pointsystem pt;// een referencie naar de point system script
    [SerializeField] coins coins;// een referencie naar de coins script
    [SerializeField] PlincoSound ps;// een referencie naar de PlincoSound script
    // Start is called before the first frame update
    void Start()
    {

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "bouncePlinco")// als de collision een gameobject een object met de naam bouncePlinco raakt
        {
            ps.PlayBoing();//speelt de PlayBoing method van de PlincoSound script
        }
        if (collision.gameObject.name == "+ balls")// als de collision een gameobject een object raakt met de naam + balls raakt
        {
            if (gameObject.name == "BulletClone")//checkt of de gameobject naam BulletClone is
            {
                Destroy(gameObject);// destroyed de gameobject
                ps.PlayFireWork();// speelt de PlayFireWork method in PlincoSound script
            }
            pt.PlusBullet();//runt de PlusBullet method in de point system script
        }
        if (collision.gameObject.name == "5 score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus5Points();// runt de Plus5Points method in de point system script
        }
        if (collision.gameObject.name == "2 score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus2Points();// runt de Plus2Points method in de point system script
        }
        if (collision.gameObject.name == "one score")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus1Point();// runt de Plus1Point method in de point system script
        }
        if ((collision.gameObject.name == "10 score"))
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.Plus10Points();// runt de Plus10Points method in de pointsystem script
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
            pt.addcoin1();// runt de addcoin1 method in pointsystem script
        }
        if(collision.gameObject.name == "2 coins")
        {
            if (gameObject.name == "BulletClone")
            {
                Destroy(gameObject);
                ps.PlayFireWork();
            }
            pt.addcoins2();//runt de addcoins2 method in pointsystem script
        }
    }

}
