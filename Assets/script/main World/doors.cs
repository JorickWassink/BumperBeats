using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{

    [SerializeField] Transform playertransform;//een transform waar de transform van de player op is gezet
    [SerializeField] coins coins;// een reference naar de coins script
    [SerializeField] TMP_Text NoCoins;// tmp text met de naam no coins



    void Start()
    {
        NoCoins.enabled = false;//zorgt ervoor dat je de text niet kan zien
    }

    public void Coinsdoor()
    {
        SceneManager.LoadScene("MathGame");// laadt de scene MathGame
    }
   
    public void firstGameDoor()
    {

        if (coins.CoinsCount < 1)// checkt of coins lager is dan 1
        {
            NoCoins.enabled = true;//zet de text zodat je hem kan zien
            StartCoroutine(wait(2));//start een coroutine dat 2 seconden duurt
            NoCoins.enabled = false;//zet de text zodat je hem niet meer kan zien
        }
        else
        {
            PlayerPrefs.SetInt("RhythRicoTempScore",0);
            coins.CoinsCount--;//verlaagt de coinscount van coins script met 1
            SceneManager.LoadScene("sam");
        }
    }
    public void pinballdoor()
    {
        if (coins.CoinsCount < 1)
        {
            NoCoins.enabled = true;
            StartCoroutine(wait(2));
            NoCoins.enabled = false;
        }
        else
        {
            coins.CoinsCount--;
            SceneManager.LoadScene("Jorick");
        }
    }
    public void PlincoDoor()
    {
        if (coins.CoinsCount < 1)
        {
            NoCoins.enabled = true;
            StartCoroutine(wait(2));
            NoCoins.enabled = false;
        }
        else
        {
            coins.CoinsCount--;
            SceneManager.LoadScene("PlincoGame");
        }
    }
    public void BreakOutDoor()
    {
        if (coins.CoinsCount < 1)
        {
            NoCoins.enabled = true;
            StartCoroutine(wait(2));
            NoCoins.enabled = false;
        }
        else
        {
            coins.CoinsCount--;
            SceneManager.LoadScene("Zeineb");
        }
    }
    public void quitdoor()
    {
        Application.Quit();//sluit de applicatie af ( werkt alleen in een build )
    }
    IEnumerator wait(float seconds)
    {

        yield return new WaitForSeconds(seconds);//return de aantal seconds dat als parameter is meegegeven
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       /* if (collision.CompareTag("Player") && transform.position == new Vector3(8, 2.07f, 0))
        {
         
        }
        if (collision.CompareTag("Player") && transform.position == new Vector3(14.5f, 5.421f, 0))
        {
         
        }
        if (collision.CompareTag("Player") && transform.position == new Vector3(23.83f, 2.17f, 0))
        {
           
        }
        if (collision.CompareTag("Player") )
        {
            SceneManager.LoadScene("Jorick");
        }
        if (collision.CompareTag("Player"))
        {
            SceneManager.LoadScene("Sam");
        }*/
    }
    
}