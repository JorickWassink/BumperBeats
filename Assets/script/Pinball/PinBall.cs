using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PinBall : MonoBehaviour
{
    private Rigidbody2D rb;
    flippers flip;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // geeft de waarde van de component die op het gameobject staat
        flip = FindAnyObjectByType<flippers>(); // geeft een link naar het flippers script
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Contains("Player")) if (flip.holdingSpace) rb.AddForce(transform.up * 1000); //als alle condities kloppen geef dan het object force omhoog
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Contains("PowerUp"))
        {
           rb.AddForce(collision.transform.up * 2000);
        }
        if (collision.gameObject.tag.Contains("YouLose"))
        {
            Destroy(gameObject); // delete het gameobject waar dit script op staat
            SceneManager.LoadScene("GameOver"); // laad een andere scene
        }
    }
}