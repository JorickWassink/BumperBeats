using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTurning : MonoBehaviour
{
    NextRound nextRound;
    ScoreKeeper scoreKeeper;

    [SerializeField] GameObject infoScreen;
    [SerializeField] public int health = 20;
    [SerializeField] float moveSpeed = 40f;
    [SerializeField] Transform playerPos; //pakt de positie van de player

    public int currentScore; //houd de score bij van het potje dat bezig is

    void Start()
    {
        infoScreen.SetActive(false);
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>();
        currentScore = PlayerPrefs.GetInt("RhythRicoTempScore");
        nextRound = FindAnyObjectByType<NextRound>();
        playerPos.position = new Vector3(0 , 0 , 0); //zet de positie van de player
        nextRound.StartRound(); //start een method in een ander script
    }

    void Update()
    {
        currentScore = PlayerPrefs.GetInt("RhythRicoTempScore"); //houd de playerpref score up to date met score die bij word gehouden

        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D)) //checkt de toets input van de player
        {
            transform.rotation = Quaternion.Euler(0, 0, 315); //zet de rotatie van de player
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D)) //hetzelfde als hierboven
        {
            transform.rotation = Quaternion.Euler(0, 0, 225); //en hier ook
        }

        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S)) //dit spreekt vanaf nu wel voorzich volgens mij
        {
            transform.rotation = Quaternion.Euler(0, 0, 135);
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0 , 0 , 0);
        }

        else if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }





        if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.RightArrow)) //en vanaf hier is het zelfde maar dan met pijltjes inplaats van WASD
        {
            transform.rotation = Quaternion.Euler(0, 0, 315);
        }

        else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 225);
        }

        else if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 135);
        }

        else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        else if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }


        if (Input.GetKey(KeyCode.I))
        {
            AudioListener.pause = true;
            infoScreen.SetActive(true);
            Time.timeScale = 0; //pauzeert de game tijd
        }

        if (Input.GetKey(KeyCode.Escape))
        {
            AudioListener.pause = false;
            infoScreen.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void PlayerHealth()
    {
        if (health == 1) //checkt of de players Health 1 is
        {
            PlayerPrefs.SetInt("RhythRicoHighScore", scoreKeeper.highScore); //zet de highscore vast in de PlayerPref
            Destroy(gameObject); //verwijderd de player
            SceneManager.LoadScene("GameOver"); //laad de gameover scene
        }

        else if (health >= 1) //checkt of de player health nog boven de 1 is
        {
            health--; //verlaagd Health bij 1
            PlayerPrefs.SetInt("RhythRicoHighScore", scoreKeeper.highScore); //zet de Highscore vast in de PlayerPRef
        }

    }
}
