using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
<<<<<<< Updated upstream

    [SerializeField] Transform playertransform;
    [SerializeField] coins coins;
    [SerializeField] TMP_Text NoCoins;
=======
    public int doorIndex;
    public bool getCoinsDoor;
    public bool MainGameDoor;
    public bool pinballDoor;
>>>>>>> Stashed changes

    void Start()
    {
<<<<<<< Updated upstream
        NoCoins.enabled = false;
=======
        doorIndex = -1;
        getCoinsDoor = false;
        MainGameDoor = false;
        pinballDoor = false;
>>>>>>> Stashed changes
    }
    
    public void Coinsdoor()
    {
        SceneManager.LoadScene("Jorick");
    }
    public void ReturnCoinsDoor()
    {
        SceneManager.LoadScene("Leon");
        playertransform.position = new Vector3(10, 1.5748f, 0);
    }
    public void firstGameDoor()
    {
<<<<<<< Updated upstream

        if(coins.CoinsCount < 1) 
        {
     
            NoCoins.enabled = false;
            StartCoroutine(wait(2));
            NoCoins.enabled = true;
     
        }
        else
        {
            coins.CoinsCount--;
            SceneManager.LoadScene("sam");
         
        }
=======
>>>>>>> Stashed changes
    }
    IEnumerator wait(float seconds)
    {
<<<<<<< Updated upstream
        yield return new WaitForSeconds(seconds);
    }
    public void ReturnFirstGameDoor()
    {
        SceneManager.LoadScene("leon");
=======
        if (collision.CompareTag("Player") && transform.position == new Vector3(8, 2.07f, 0))
        {
            doorIndex = 0;
            getCoinsDoor = true;
        }
        if (collision.CompareTag("Player") && transform.position == new Vector3(14.5f, 5.421f, 0))
        { doorIndex = 1;
            MainGameDoor = true;
        }
        if(collision.CompareTag("Player") && transform.position == new Vector3(23.83f, 2.17f, 0))
        {
            doorIndex = 2;
            pinballDoor = true;
        }
        if (collision.CompareTag("Player") && getCoinsDoor == true)
        {
            SceneManager.LoadScene("Jorick");
        }
        if (collision.CompareTag("Player") && MainGameDoor == true)
        {
            SceneManager.LoadScene("Sam");
        }
>>>>>>> Stashed changes
    }
}
