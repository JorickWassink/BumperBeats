using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource sound; // maakt een nieuwe private var aan van een audio source
    void Start() //runt meteen een keer wanneer het script gecalled word
    {
        sound = GetComponent<AudioSource>(); // geeft de waarde van een audiosource component die op het gameobject staat
    }

    private void OnTriggerEnter2D(Collider2D collision) // wanneer er iets dit object zijn collider aanraakt waar Is Trigger aan staat dan runt het de code
    {
        sound.Play(); // speel de audiosource af
    }
    private void OnCollisionEnter2D(Collision2D collision)// wanneer iets collide met de collider van dit gameobject runt het de code
    {
        sound.Play();
    }
}
