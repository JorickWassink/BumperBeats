
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.AssetDatabaseExperimental.AssetDatabaseCounters;

public class BumperSpin : MonoBehaviour
{
    int rotation = 0;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        rotation++;
    }
}
