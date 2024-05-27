using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    private Rigidbody2D rb;
    private int force = 5;
    flippers flip;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flip = FindAnyObjectByType<flippers>(); 
        // save kant op waar die heen gaat
        // push steeds mee naar die kant met velocity
        // die omhoog gaat als je een bumper aanraakt
    }

    private void Update()
    {
        //print(flip.holdingSpace);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player")) if (flip.holdingSpace) rb.AddForce(transform.up * 1000);
    }
}
