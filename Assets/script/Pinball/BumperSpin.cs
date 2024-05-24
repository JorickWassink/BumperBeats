
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BumperSpin : MonoBehaviour
{
    int rotation = 0;
    void FixedUpdate()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        rotation += 5;
    }
}
