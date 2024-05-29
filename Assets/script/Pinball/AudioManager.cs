using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    AudioSource sound;
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sound.Play();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        sound.Play();
    }
}
