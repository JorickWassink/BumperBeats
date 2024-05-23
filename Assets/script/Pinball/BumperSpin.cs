

using UnityEngine;


public class BumperSpin : MonoBehaviour
{
    int rotation = 0;
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, rotation);
        rotation++;
    }
}
