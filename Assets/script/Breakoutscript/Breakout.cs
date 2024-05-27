using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    [SerializeField] GameObject powerup;
    public TMP_Text scoretext;
    public Rigidbody2D rbBall;
    int blokjesAantal = 98;
    public int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rb
        rbBall.velocity = new Vector2(rbBall.velocity.x, -6.5f); //De velocity van de
    }

    private void OnTriggerEnter2D(Collider2D collision) //Class voor als de ander iets anders aanraakt.
    {
        if (collision.tag == "blokjes") //Als iets wordt aangeraakt met de tag blokjes dan gebeurt dit.
        {
            blokjesAantal--;
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
        if (pblokje)
        {
            Destroy(pblokje.gameObject); //De blokje wordt destroyed.
            score++;
        }
    }


    void PowerUps()
    {
        int randomNumber = Random.Range(0, 10);
        if (randomNumber == 6)
        {
            //powerup;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (score != 0 && scoretext != null) //checkt of score niet 0 is of de text niet leeg is
        {
            scoretext.text = score.ToString(); //Zet score naar een string.
        }
        rbBall.velocity = new Vector2(rbBall.velocity.x, rbBall.velocity.y);
    }
    //blabla
}