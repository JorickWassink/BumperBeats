using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathBullet : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] GameObject target;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        target = GameObject.Find("end");
    }
    // Update is called once per frame
    void Update()
    {
        rb.AddForce(target.transform.position,ForceMode2D.Impulse);
    }
} 
