using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{

    [SerializeField] Transform playertransform;
    [SerializeField] coins coins;
    [SerializeField] TMP_Text NoCoins;



    void Start()
    {
        NoCoins.enabled = false;
    }

    public void Coinsdoor()
    {
        SceneManager.LoadScene("MathGame");
    }
    public void ReturnCoinsDoor()
    {
        SceneManager.LoadScene("Leon");
        playertransform.position = new Vector3(10, 1.5748f, 0);
    }
    public void firstGameDoor()
    {

        if (coins.CoinsCount < 1)
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
    }
    public void pinballdoor()
    {
        if (coins.CoinsCount < 1)
        {
            NoCoins.enabled = false;
            StartCoroutine(wait(2));
            NoCoins.enabled = true;
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
            NoCoins.enabled = false;
            StartCoroutine(wait(2));
            NoCoins.enabled = true;
        }
        else
        {
            coins.CoinsCount--;
            SceneManager.LoadScene("PlincoGame");
        }
    }
    IEnumerator wait(float seconds)
    {

        yield return new WaitForSeconds(seconds);
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