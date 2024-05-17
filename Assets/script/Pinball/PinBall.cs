using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private int force = 5;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        // save kant op waar die heen gaat
        // push steeds mee naar die kant met velocity
        // die omhoog gaat als je een bumper aanraakt
    }

    void LateUpdate()
    {        
        Vector3 wDirection = rb.velocity.normalized;
        Vector3 lDirection = Vector3.right;

        Vector3 currentWDirection = transform.TransformDirection(lDirection);

        float angleDiff = Vector3.SignedAngle(currentWDirection,wDirection, Vector3.forward);

        transform.Rotate(Vector3.forward, angleDiff, Space.World);
    }

    //private void OnCollisionEnter2D(Collision2D collision)
    //{
    //    if (collision.gameObject.tag.Contains("Bumper"))
    //    {
    //        rb.AddForce(transform.forward * 5);
    //    }        
    //}
}
