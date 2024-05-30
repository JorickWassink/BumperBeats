
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BumperSpin : MonoBehaviour
{
    int rotation = 0;// maakt een int aan en geeft die meteen een waarde
    public int speed = 5;
    void FixedUpdate() // fixed update runt elke fixed frame
    {
        // de code hieronder zorgt ervoor dat elke fixed frame de rotation van het object omhoog gaat met de waarde van de speed var
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        rotation += speed;
    }
}
