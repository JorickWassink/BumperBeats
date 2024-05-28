using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    [SerializeField] GameObject powerUp; //Een gameobject voor powerUp
    public TMP_Text scoretext; //De score
    public Rigidbody2D rbBall;
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
            StartCoroutine(BlokjesDelay(collision.gameObject)); //De blokjes worden niet gelijk verwijdert zodat de bal
                                                                //nog tijd heeft om terug te stuiteren

            int randomNumber = Random.Range(0, 11);
            if (randomNumber == 6)
            {
                GameObject powerUpObject = Instantiate(powerup); //De powerup wordt opgeslagen in de powerupobject gameobject
                powerUpObject.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
            }
        }

        if (collision.tag == "YouLose") //Als je de rode lijn onderin aanraakt
        {
            Destroy(gameObject); //De bal wordt destroyt
        }

    }


    IEnumerator BlokjesDelay(GameObject pblokje) //Een class dat de blokjes delayed zodat de blokjes niet gelijk verwdwijnen
    {
        yield return new WaitForSeconds(0.05f); //De waiting voordat de blokje weggaat is 0.1f
        if (pblokje)
        {
            Destroy(pblokje.gameObject); //De blokje wordt destroyed.
            score++;
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