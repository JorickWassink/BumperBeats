using UnityEngine;

public class plincoGun : MonoBehaviour
{
    [SerializeField] GameObject bullet; // een gameobject
    [SerializeField] Rigidbody2D rb; // een rigidbody
    public Transform startPos; // een public transform voor de begin positie
    public Transform endPos; // een public transform voor de eind positie
    private Vector3 targetPos;
    Vector3 currentPos;

    private void Start()
    {
        targetPos = startPos.position;// zet targetPos naar startPos
    }

    private void FixedUpdate()
    {
        currentPos = transform.position;

        float distanceToStart = Vector3.Distance(currentPos, startPos.position);
        float distanceToEnd = Vector3.Distance(currentPos, endPos.position);

        if (distanceToStart < 0.1f)
        {
            targetPos = endPos.position;
        }
        else if (distanceToEnd < 0.1f)
        {
            targetPos = startPos.position;
        }

        Vector3 targetDirection = (targetPos - currentPos).normalized;
        rb.MovePosition(currentPos + targetDirection * Time.deltaTime * 5f);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(bullet, currentPos +  new Vector3 (0, -1 , 0), Quaternion.identity);
        }
        
    }
}
