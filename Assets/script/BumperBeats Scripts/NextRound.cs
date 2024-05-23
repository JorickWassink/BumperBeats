using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;

public class NextRound : MonoBehaviour
{
    int randomEnemy;
    bool waiting = false;
    public int enemyAmount = 8;

    [SerializeField] GameObject slowEnemy;
    [SerializeField] GameObject midEnemy;
    [SerializeField] GameObject fastEnemy;
    [SerializeField] List<Transform> transforms = new List<Transform>();
    [SerializeField] AudioSource voiceTalking;
    [SerializeField] AudioSource backGroundBeat;

    PlayerTurning playerTurning;

    void Start()
    {
        playerTurning = FindAnyObjectByType<PlayerTurning>();
    }

    void Update()
    {
        print(enemyAmount);

        if (enemyAmount <= 0)
        {
            if (waiting == false) 
            {
                StartCoroutine(StartNextRound());
            }
        }
    }

    IEnumerator StartNextRound()
    {
        backGroundBeat.Stop();
        voiceTalking.Play();

        GameObject[] bullets = GameObject.FindGameObjectsWithTag("Respawn");
        foreach (GameObject bullet in bullets)
        {
            Destroy(bullet);
        }

        waiting = true;
        enemyAmount = 8;

        yield return new WaitForSeconds(2);

        backGroundBeat.Play();
        playerTurning.health = 20;
        foreach (Transform t in transforms)
        {
            randomEnemy = Random.Range(0, 3);
            switch (randomEnemy)
            {
                case 0:
                    Instantiate(slowEnemy, t.position, Quaternion.identity);
                    break;

                case 1:
                    Instantiate(midEnemy, t.position, Quaternion.identity);
                    break;

                case 2:
                    Instantiate(fastEnemy, t.position, Quaternion.identity);
                    break;
            }
        }
        waiting = false;
    }
}
