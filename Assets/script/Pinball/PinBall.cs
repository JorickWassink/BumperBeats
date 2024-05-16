using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    private Rigidbody2D rb;
    float speed;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // save kant op waar die heen gaat
        // push steeds mee naar die kant met velocity
        // die omhoog gaat als je een bumper aanraakt
    }

    // Update is called once per frame
    void Update()
    {
        //rb.velocity += 
    }

    void LateUpdate()
    {
        
        Vector3 worldDirectionToPointForward = rb.velocity.normalized;
        Vector3 localDirectionToPointForward = Vector3.right;

        Vector3 currentWorldForwardDirection = transform.TransformDirection(
                localDirectionToPointForward);
        float angleDiff = Vector3.SignedAngle(currentWorldForwardDirection,
                worldDirectionToPointForward, Vector3.forward);

        transform.Rotate(Vector3.forward, angleDiff, Space.World);
    }
}
