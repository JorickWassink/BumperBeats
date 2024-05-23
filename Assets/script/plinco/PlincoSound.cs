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
        boing.Play();//speelt de boing sound
        StartCoroutine(wait(1f));//start een corountine dat 1 seconde duurt
    }
    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);//return de aantal seconds dat als parameter is meegegeven
    }
    public void PlayFireWork()
    {
        fireworks.Play();//speelt de firework sound
    }
}
