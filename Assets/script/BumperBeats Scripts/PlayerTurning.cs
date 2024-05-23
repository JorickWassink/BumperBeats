using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTurning : MonoBehaviour
{
    public int health = 20;
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
        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("Leon");
        }


        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 315);
        }

        else if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 225);
        }

        else if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 135);
        }

        else if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 45);
        }

        else if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Euler(0 , 0 , 0);
        }

        else if(Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Euler(0, 0, 90);
        }

        else if (Input.GetKey(KeyCode.S))
        {
            transform.rotation = Quaternion.Euler(0, 0, 180);
        }

        else if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Euler(0, 0, 270);
        }

        
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDirection * moveSpeed);

    }

    public void PlayerHealth()
    {
        if (health >= 1)
        {
            health--;
        }

        else
        {
            Destroy(gameObject);
        }
    }

}
