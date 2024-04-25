using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answers : MonoBehaviour
{
    public int index;
    MathGame game;
    MathPlayer player;
    GameObject objectD;
    private void Start()
    {
        game = FindAnyObjectByType<MathGame>();
        player = FindAnyObjectByType<MathPlayer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (index == 0)
        {
            if (game.whichOne == 1)
            {
                objectD = GameObject.Find("A");
                Destroy(objectD);
                game.somText.text = "Goed!";
                player.canShoot = false;
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
            }
            print("A");
        }
        else if (index == 1)
        {
            if (game.whichOne == 2)
            {
                objectD = GameObject.Find("B");
                Destroy(objectD);
                game.somText.text = "Goed!";
                player.canShoot = false;
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
            }
            print("B");
        }
        else if (index == 2)
        {
            if (game.whichOne == 4)
            {
                objectD = GameObject.Find("C");
                Destroy(objectD);
                game.somText.text = "Goed!";
                player.canShoot = false;
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
            }
            print("C");
        }
        else if(index == 3)
        {
            if (game.whichOne == 3)
            {
                objectD = GameObject.Find("D");
                Destroy(objectD);
                game.somText.text = "Goed!";
                player.canShoot = false;
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
            }
            print("D");
        }
    }
}
