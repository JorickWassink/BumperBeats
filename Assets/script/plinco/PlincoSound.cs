using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlincoSound : MonoBehaviour
{
    public AudioSource boing;
    public AudioSource fireworks;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PlayBoing()
    {
        boing.Play();
        StartCoroutine(wait(1f));
    }
    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
    public void PlayFireWork()
    {
        fireworks.Play();
    }
}
