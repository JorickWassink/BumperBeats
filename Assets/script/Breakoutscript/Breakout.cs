using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    [SerializeField] GameObject powerup;
    public Rigidbody2D rbBall;
    int blokjesAantal = 98;
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


        if (collision.tag == "PowerUp") //Als je de powerup aanraakt dan gebeurt dit
        {
            Destroy(collision.gameObject);//Destroyed de gameobject van powerup
        }

    }

    IEnumerator BlokjesDelay(GameObject pblokje) //Een class dat de blokjes delayed zodat de blokjes niet gelijk verwdwijnen
    {
        yield return new WaitForSeconds(0.1f); //De waiting voordat de blokje weggaat is 0.1f
        Destroy(pblokje.gameObject); //De blokje wordt destroyed.
    }

    void PowerUps()
    {
        //Random.Range(1,)
        if (blokjesAantal <= 24.5f)
        {

        } else if (blokjesAantal == 49)
        {

        } else if (blokjesAantal == 70)
        {

        } else if (blokjesAantal == 84)
        {

        }
    }

    // Update is called once per frame
    void Update()
    {
        rbBall.velocity = new Vector2(rbBall.velocity.x, rbBall.velocity.y);
    }
    //blabla
}