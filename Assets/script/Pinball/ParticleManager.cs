using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    ParticleSystem part; // maakt een nieuwe particle system var aan
    // Start is called before the first frame update
    void Start()
    {
        part = GetComponentInChildren<ParticleSystem>(); // geeft de var de waarde van een
    }

    private void OnTriggerEnter2D(Collider2D collision) // als iets met de trigger van het gameobject collide dan runt het de code
    {
        if (collision.gameObject.tag.Contains("Player")) part.Play(); // als het object dat heeft gecollide met de trigger de tag Player heeft dan runt het de code
    }
    private void OnCollisionEnter2D(Collision2D collision) // als iets met de collider van het gameobject collide dan runt het de code
    {
        if (collision.gameObject.tag.Contains("Player")) part.Play();
    }
}
