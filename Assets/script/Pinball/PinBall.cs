using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PinBall : MonoBehaviour
{
    private Rigidbody2D rb;
    flippers flip;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        flip = FindAnyObjectByType<flippers>(); 
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player")) if (flip.holdingSpace) rb.AddForce(transform.up * 1000);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("PowerUp"))
        {
           rb.AddForce(collision.transform.up * 2000);
        }
    }
}