using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    public Rigidbody2D rbBall;
    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rb
        rbBall.velocity = new Vector2(rbBall.velocity.x, -5);
    }

    private void OnTriggerEnter2D(Collider2D collision) //Class voor als de ander iets anders aanraakt.
    {
        if (collision.tag == "blokjes") //Als iets wordt aangeraakt met de tag blokjes dan gebeurt dit.
        {
            StartCoroutine(BlokjesDelay(collision.gameObject)); //De blokjes worden niet gelijk verwijdert zodat de bal
                                                                //nog tijd heeft om terug te stuiteren
        }

        if (collision.tag == "YouLose") //Als je de rode lijn onderin aanraakt
        {
            SceneManager.LoadScene("GameOver"); //Als je af gaat gaat ie terug naar hubworld
        }

    }

    IEnumerator BlokjesDelay(GameObject pblokje) //Een class dat de blokjes delayed zodat de blokjes niet gelijk verwdwijnen
    {
        yield return new WaitForSeconds(0.1f); //De waiting voordat de blokje weggaat is 0.1f
        Destroy(pblokje.gameObject); //De blokje wordt destroyed.
    }

    // Update is called once per frame
    void Update()
    {
        rbBall.velocity = new Vector2(rbBall.velocity.x, rbBall.velocity.y);
    }
    //blabla
}