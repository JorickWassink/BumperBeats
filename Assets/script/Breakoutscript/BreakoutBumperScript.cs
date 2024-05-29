using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BreakoutBumperScript : MonoBehaviour
{
    float horizontal; //Een float voor horizontale beweging van de bumper
    Rigidbody2D player; //De rigidbody
    [SerializeField] float speed = 17.5f; //De float speed staat op 17.5f 
    [SerializeField] Breakout scoreReference; //Een reference voor de score die in Breakout script staat.

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en slaat het op als player
    }

    // Update is called once per frame 
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); //Hij zoekt bij input manager de horizontal.
        player.velocity = new Vector2(horizontal * speed, 0); //De velocity van de bumper (player) staat op bewegen op x

        if (transform.position.x <= -8.714)//Als de position van de x kleiner of gelijk is aan -8.714 dan gebeurt dit
        {
            //De positie wordt veranderd naar wat er tussen de haakjes staat, zodat het niet buiten de map gaat.
            transform.position = new Vector3(-8.714f, transform.position.y, 0);
        }

        if (transform.position.x >= 8.42)//Als de position van x groter of gelijk is aan 8.42
        {
            //De positie van x, y en z wordt veranderd naar wat er tussen de haakjes staat.
            transform.position = new Vector3(8.42f, transform.position.y, 0);
        }

        //Als gameobject met de tag Ball en PowerUp null is gebeurt dit
        if (GameObject.FindGameObjectWithTag("Ball") == null && GameObject.FindGameObjectWithTag("PowerUp") == null)
        {
            if (scoreReference.score > PlayerPrefs.GetInt("highscoreBreakout")) //GetInt krijg je de waarde van de key.
            {
                PlayerPrefs.SetInt("highscoreBreakout", scoreReference.score); //set int geeft waarde

            }
            SceneManager.LoadScene("GameOver"); //Als je af gaat gaat ie terug naar hubworld
        }

        if (GameObject.FindGameObjectWithTag("blokjes") == null) //Als de blokjes op/leeg zijn gebrurt dit.
        {
            SceneManager.LoadScene("GameOver"); //Als je gewonnen hebt, gaat ie terug naar hubworld
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameOver"); //Als je escape klikt, gaat ie terug naar hubworld
        }
    }
}
