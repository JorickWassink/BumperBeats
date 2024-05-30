using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Answers : MonoBehaviour
{
    [SerializeField] coins Coins; // maakt een private var aan die je een waarde kan geven in de inspector
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
                objectD = GameObject.Find("A"); // geeft de waarde van de gameobject met de aangegeven naam
                Invoke("BackToMenu", 2); // runt de method BackToMenu na 2 seconden
                
                game.somText.text = "Goed!"; // veranderdt de text van het text object
                player.canShoot = false;
                Coins.addcoin(); // runt een method uit een gelinked script
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
                Invoke("BackToMenu", 2);
            }
            print("A");
        }
        else if (index == 1)
        {
            if (game.whichOne == 2)
            {
                objectD = GameObject.Find("B");
                Invoke("BackToMenu", 2);
                
                game.somText.text = "Goed!";
                player.canShoot = false;
                Coins.addcoin();
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
                Invoke("BackToMenu", 2);
            }
            print("B");
        }
        else if (index == 2)
        {
            if (game.whichOne == 4)
            {
                objectD = GameObject.Find("C");
                Invoke("BackToMenu", 2);
                
                game.somText.text = "Goed!";
                player.canShoot = false;
                Coins.addcoin();
            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
                Invoke("BackToMenu", 2);
            }
            print("C");
        }
        else if(index == 3)
        {
            if (game.whichOne == 3)
            {
                objectD = GameObject.Find("D");
                Invoke("BackToMenu", 2);
                
                game.somText.text = "Goed!";
                player.canShoot = false;
                Coins.addcoin();

            }
            else
            {
                game.somText.text = "Fout!";
                player.canShoot = false;
                Invoke("BackToMenu", 2);
            }
            print("D");
        }
    }
    private void BackToMenu() // maakt een nieuwe private method aan die niet gebruikt kan worden buiten dit script
    {
        SceneManager.LoadScene("GameOver");
    }
}
