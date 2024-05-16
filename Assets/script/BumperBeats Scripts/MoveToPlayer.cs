using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    EnemyThing enemyThing;
    [SerializeField] float force = 10;
    [SerializeField] Transform playerTarget;
    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(playerTarget.position - transform.position * force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("Bumper"))
        {
            rb.AddForce(playerTarget.position - transform.position * -200);
        }
    }
}