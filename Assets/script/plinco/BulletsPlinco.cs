using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletsPlinco : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    public void Destroyobject()
    {
        Destroy(gameObject);
    }

}
