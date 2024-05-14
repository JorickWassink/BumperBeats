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
        SceneManager.LoadScene("Jorick");
    }
    public void ReturnCoinsDoor()
    {
        SceneManager.LoadScene("Leon");
        playertransform.position = new Vector3(10, 1.5748f, 0);
    }
    public void firstGameDoor()
    {

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
    }
    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    public void ReturnFirstGameDoor()
    {
        SceneManager.LoadScene("leon");
    }
}
