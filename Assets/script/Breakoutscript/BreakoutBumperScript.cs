using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutBumperScript : MonoBehaviour
{
    float horizontal;
    Rigidbody2D player;
    [SerializeField] float speed = 12f;
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rb
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        player.velocity = new Vector2(horizontal * speed,0);
    }
}
