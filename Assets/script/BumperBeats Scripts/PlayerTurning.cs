using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTurning : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] float moveSpeed = 40f;
    [SerializeField] float rotationSpeed = 90f;

    Vector2 moveDirection;
    Rigidbody2D rb = null;
    void Start()
    {
        playerPos.position = new Vector3(0 , 0 , 0);
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float rotate = Input.GetAxis("Horizontal"); 

        transform.Rotate(new Vector3(0, 0, -1) * rotate * Time.deltaTime * rotationSpeed);
    }

    void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveSpeed);
    }
}
