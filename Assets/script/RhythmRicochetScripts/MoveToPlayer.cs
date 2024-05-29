using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    bool canKillEnemy = false;

    [SerializeField] float force = 10; //serialize field voor een float, zodat het via unity snel kan aangepast worden
    [SerializeField] Transform playerTarget;

    NextRound nextRound;
    PlayerTurning playerTurning;
    Rigidbody2D rb;
    ScoreKeeper scoreKeeper;

    void Start()
    {
        transform.up = playerTarget.position - transform.position; //laat de kogel naar de player richten
        scoreKeeper = FindAnyObjectByType<ScoreKeeper>(); //pakt onderdelen uit een ander script
        nextRound =  FindAnyObjectByType<NextRound>();
        playerTurning = FindAnyObjectByType<PlayerTurning>();
        rb = gameObject.GetComponent<Rigidbody2D>(); //pakt de rigidbody van de bullet
        rb.AddForce(playerTarget.position - transform.position * force); //duwt een kracht in de richting van de player
    }

    private void OnTriggerEnter2D(Collider2D collision) //method om te kijken of de collider van de bullet in contact komt met iets
    {
        if (collision.gameObject.CompareTag("Enemy")) //checkt of de bullet in contact komt met de een GameObject dat de tag Enemy heeft
        {
            Destroy(gameObject); //verwijderd het gameobject waar dit script op zit, in dit geval dus de bullet
            if (canKillEnemy == true) //checkt of de bullet eerst de bumper heeft geraakt
            {
                scoreKeeper.totalScore += 100; //verhoogt de score bij 100
                Destroy(collision.gameObject); //verwijderd de enemy
                nextRound.enemyAmount--; //verminderd de enemy count check bij 1
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            playerTurning.PlayerHealth(); //start een method in een ander script
        }

        if (collision.gameObject.CompareTag("Bumper"))
        {
            canKillEnemy = true;
            transform.up = playerTarget.position + transform.position; //zet de rotatie van de bullet richting de enemy
            rb.AddForce(playerTarget.position - transform.position * -200); //geeft een force in de richting van de enemy
        }
    }
}