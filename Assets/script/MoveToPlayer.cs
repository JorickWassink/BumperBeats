using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{
    [SerializeField] float force = 10;
    [SerializeField] Transform playerTarget;
    bool hitPlayer = false;
    Rigidbody2D rb;

    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        rb.AddForce(playerTarget.position - transform.position * force);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}