using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    bool canKillEnemy = false;

    [SerializeField] float force = 10;
    [SerializeField] Transform playerTarget;

    NextRound nextRound;
    PlayerTurning playerTurning;
    Rigidbody2D rb;


    void Start()
    {
        nextRound =  FindAnyObjectByType<NextRound>();
        playerTurning = FindAnyObjectByType<PlayerTurning>();
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(playerTarget.position - transform.position * force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            if (canKillEnemy == true)
            {
                Destroy(collision.gameObject);
                nextRound.enemyAmount--;
            }
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
            playerTurning.PlayerHealth();
        }

        if (collision.gameObject.CompareTag("Bumper"))
        {
            canKillEnemy = true;
            rb.AddForce(playerTarget.position - transform.position * -200);

        }
    }
}