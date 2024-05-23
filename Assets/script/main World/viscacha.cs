using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viscacha : MonoBehaviour
{
    [SerializeField] coins coins;
    [SerializeField] GameObject Viscacha;// een reference naar de viscacha gameobject
    // Start is called before the first frame update
    void Start()
    {
        Viscacha.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (coins.CoinsCount > 10)
        {
            Viscacha.SetActive(true);
        }
    }
}
