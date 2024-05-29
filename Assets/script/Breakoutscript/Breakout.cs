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
    public Rigidbody2D rbBall; //Een rigidbody voor de ball
    float maxSpeedBall = 7f; //max snelheid is 7f
    float minSpeedBall = 5f; //min snelheid is 4f
    public int score = 0; //Score staat op 0

    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rbBall
        rbBall.velocity = new Vector2(rbBall.velocity.x, -6.5f); //De velocity van rbBall krijgt een positie

    }

    private void OnTriggerEnter2D(Collider2D collision) //Class voor als de een object iets aanraakt.
    {
        if (collision.tag == "blokjes") //Als iets wordt aangeraakt met de tag blokjes dan gebeurt dit.
        {
            StartCoroutine(BlokjesDelay(collision.gameObject)); //De blokjes worden niet gelijk verwijdert zodat de bal
                                                                //nog tijd heeft om terug te stuiteren
            int randomNumber = Random.Range(0, 11); //Een int voor een random nummer tussen de 0 en 11
            if (randomNumber == 6) //Als de random nummer landt op 6 dan gebeurt dit
            {
                GameObject powerUpObject = Instantiate(powerUp); //De powerUp wordt gecloned en opgeslagen in de powerUpObject gameobject.
                //De clone krijgt een niewe positie en dat is de positie van de blokje.
                powerUpObject.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
            }

        }

        if (collision.tag == "YouLose") //Als je de rode lijn onderin aanraakt
        {
            Destroy(gameObject); //De bal wordt destroyt
        }

    }


    IEnumerator BlokjesDelay(GameObject pblokje) //Een class dat de blokjes delayed zodat de blokjes niet gelijk verwdwijnen met een parameter van de blokje
    {
        yield return new WaitForSeconds(0.05f); //De waiting voordat de blokje weggaat is 0.05f
        if (pblokje)
        {
            Destroy(pblokje.gameObject); //De blokje wordt destroyed na 0.05f.
            score++; //De score gaat omhoog met 1
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (score != 0 && scoretext != null) //checkt of score niet 0 is of de text niet leeg is
        {
            scoretext.text = score.ToString(); //Zet score naar een string.
        }
        rbBall.velocity = new Vector2(rbBall.velocity.x, rbBall.velocity.y); //De velocity van de bal krijgt een nieuwe positie van de x en y.

        if (rbBall.velocity.magnitude > maxSpeedBall) //Als de snelheid van de gameobject groter is dan maxspeed
        {
            rbBall.velocity = rbBall.velocity.normalized * maxSpeedBall; //Dan wordt de snelheid veranderd
        }

        if (rbBall.velocity.magnitude < minSpeedBall) //ALs de snelheid van de gameobject kleiner is dan minspeed
        {
            rbBall.velocity = rbBall.velocity.normalized * minSpeedBall;//Dan wordt de snelheid aangepast.
        }
    }
}