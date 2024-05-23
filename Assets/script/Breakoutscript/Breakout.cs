using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Breakout : MonoBehaviour
{
    public Rigidbody2D rbBall;
    bool blokjes = false;
    // Start is called before the first frame update
    void Start()
    {
        rbBall = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rb
        rbBall.velocity = new Vector2(rbBall.velocity.x, -5);
    }

    private void OnTriggerEnter2D(Collider2D collision) // classs voor als de ander iets anders aanraakt.
    {
        if (collision.tag == "blokjes") //als iets wordt aangeraakt met de tag blokjes dan gebeurt dit.
        {
            blokjes = true; // de bool blokjes staat nu op true
            StartCoroutine(BlokjesDelay(collision.gameObject));
        }
        if (collision.tag == "bumperBreakout") //Als iets wordt aangeraakt met de tag bumperBreakout dan gebeurt dit.
        {
            blokjes = true;
        }


    }

    IEnumerator BlokjesDelay(GameObject pblokje)
    {
        yield return new WaitForSeconds(0.2f);
        Destroy(pblokje.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        rbBall.velocity = new Vector2(rbBall.velocity.x, rbBall.velocity.y );
    }
    //blabla
}