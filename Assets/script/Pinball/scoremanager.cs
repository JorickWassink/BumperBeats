using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class scoremanager : MonoBehaviour
{
    [SerializeField] TMP_Text score;
    int scoreInt = 0;
    void Update()
    {
        score.text = scoreInt.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bumper")) scoreInt += 25;
    }
}

