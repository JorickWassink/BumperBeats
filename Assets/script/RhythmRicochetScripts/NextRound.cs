using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextRound : MonoBehaviour
{
    int randomEnemy;
    bool waiting = false; //boolean om te checken of er een ronde bezig is of niet
    public int enemyAmount = 8; //het aantal enemy's in de scene

    [SerializeField] GameObject slowEnemy; //called een gameobject
    [SerializeField] GameObject midEnemy;
    [SerializeField] GameObject fastEnemy;
    [SerializeField] AudioSource roundStart; //called een audiosource
    [SerializeField] AudioSource backGroundBeat;
    [SerializeField] ScoreKeeper scoreKeeper; //called een ander script
    [SerializeField] List<Transform> transforms = new List<Transform>(); //list voor alle Transform posities van de spawnpunten

    PlayerTurning playerTurning;

    void Start()
    {
        playerTurning = FindAnyObjectByType<PlayerTurning>();
    }

    void Update()
    {
        if (enemyAmount <= 0) //checkt of alle enemy's weg zijn
        {
            if (waiting == false) //checked of de wachttijd voorbij is
            {
                PlayerPrefs.SetInt("RhythRicoTempScore", scoreKeeper.totalScore); //update de score naar de Playerpref voor de score
                SceneManager.LoadScene("Sam"); //herlaad de scene zodat een nieuwe ronde gestart kan worden
            }
        }
    }

    public void StartRound() //method om de Coroutine StartNextRound te starten vanaf een ander script
    {
        StartCoroutine(StartNextRound()); //start de coroutine StartNextRound 
    }

    public IEnumerator StartNextRound() //IEnumerator om een timer te zetten voor de ronde wordt geladen
    {
        backGroundBeat.Stop(); //stopt de achtergrond audio
        roundStart.Play(); //start het countdown deuntje
        waiting = true;
        enemyAmount = 8;

        yield return new WaitForSeconds(2); //alle code wat hierna staat wordt 2 seconden later uitgevoerd

        backGroundBeat.Play(); //start de achtergond audio
        playerTurning.health = 20; //reset de playerHealth naar 20

        foreach (Transform t in transforms) //gaat door elke transform positie in de lijst transforms
        {
            randomEnemy = Random.Range(0, 3); //pakt een random getal tussen 0 en 3, dus 0, 1 of 2

            switch (randomEnemy) //switch case voor random enemy spawns, kiest een langzame, normale of snelle enemy, gekozen door het random getal
            {
                case 0:
                    Instantiate(slowEnemy, t.position, Quaternion.identity); //spawnt een langzame enemy
                    break;

                case 1:
                    Instantiate(midEnemy, t.position, Quaternion.identity); //spawnt een normale enemy
                    break;

                case 2:
                    Instantiate(fastEnemy, t.position, Quaternion.identity); //spawnt een snelle enemy
                    break;
            }
        }
        waiting = false; //stopt met wachten
    }
}
