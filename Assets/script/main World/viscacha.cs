using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class viscacha : MonoBehaviour
{
    [SerializeField] coins coins;//een reference voor coins script
    [SerializeField] GameObject Viscacha;// een reference naar de viscacha gameobject
    // Start is called before the first frame update
    void Start()
    {
        Viscacha.SetActive(false);//zet viscacha gameobject op uit
    }

    // Update is called once per frame
    void Update()
    {
        if (coins.CoinsCount > 10)//checktof coinscount hoger is dan 10
        {
            Viscacha.SetActive(true);//zet viscacha gameobject op aan
        }
    }
}
