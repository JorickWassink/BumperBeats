using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class flippers : MonoBehaviour
{
    public int id; // maakt een public var aan die in andere scripts gebruikt kan worden als die een reference naar deze script hebben
    float speed = 25f;
    [SerializeField] Transform target1; // serializefield zorgt ervoor dat je in de het in de inspector een waarde kan geven 
    [SerializeField] Transform target2;
    [SerializeField] Transform start1;
    [SerializeField] Transform start2;
    public bool holdingSpace = false;
    private void Update() //runt elke frame
    {
        if (Input.GetKey(KeyCode.Space)) // als de speler spatie indrukt
        {
            holdingSpace = true;
            if (id == 1) transform.rotation = Quaternion.Lerp(transform.rotation, target1.rotation, Time.deltaTime * speed);
            //quaternion.lerp zorgt ervoor dat het object smooth van een positie naar een andere positie beweegt de snelheid word bepaald door in dit geval de speed var
            else if (id == 2) transform.rotation = Quaternion.Lerp(transform.rotation, target2.rotation, Time.deltaTime * speed);
        }
        else // als geen andere condities kloppen dan runt het de code tussen de accolades hieronder
        {
            holdingSpace = false;
        }
        
        if (!holdingSpace)
        {
            if (id == 1) transform.rotation = Quaternion.Lerp(transform.rotation, start1.rotation, Time.deltaTime * speed);
            else if (id == 2) transform.rotation = Quaternion.Lerp(transform.rotation, start2.rotation, Time.deltaTime * speed);
        }
    }

}
