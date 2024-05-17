using UnityEngine;

public class PlincoGun : MonoBehaviour
{
    [SerializeField] GameObject bullet;
    [SerializeField] Rigidbody2D rb;
    public Transform startPos;
    public Transform endPos;
    private Vector3 targetPos;
    int bulletcount;

    public void Start()
    {
        bulletcount = 10;
        targetPos = startPos.position;
    }
    public void plusbullet()
    {
        bulletcount++;
    }

    private void FixedUpdate()
    {
        Vector3 currentPos = transform.position;

        float distanceToStart = Vector3.Distance(currentPos, startPos.position);
        float distanceToEnd = Vector3.Distance(currentPos, endPos.position);


        // Calculate the direction to the target position
        Vector3 targetDirection = (targetPos - currentPos).normalized;

        // Move gun towards the target position
        rb.MovePosition(currentPos + targetDirection * Time.deltaTime * 5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletcount--;
            Instantiate(bullet, transform.position - new Vector3(0,1,0), Quaternion.identity);
        }
        if(bulletcount == 0)
        {

        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "StartPos" ) 
        {
            targetPos = endPos.position;
        }
        if(collision.gameObject.name == "EndPos")
        {
            targetPos = startPos.position;
        }
    }
}
