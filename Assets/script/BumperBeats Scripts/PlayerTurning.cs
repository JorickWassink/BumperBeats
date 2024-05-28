using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTurning : MonoBehaviour
{
    NextRound nextRound = new NextRound();

    [SerializeField] public int health = 20;
    [SerializeField] float moveSpeed = 40f;
    [SerializeField] float rotationSpeed = 90f;
    [SerializeField] Transform playerPos;

    public int currentScore;

    Rigidbody2D rb = null;

    Vector2 moveDirection;

    void Start()
    {
        currentScore = PlayerPrefs.GetInt("RhythRicoTempScore");
        nextRound = FindAnyObjectByType<NextRound>();
        playerPos.position = new Vector3(0 , 0 , 0);
        rb = GetComponent<Rigidbody2D>();
        nextRound.StartRound();
    }

    void Update()
    {
        currentScore = PlayerPrefs.GetInt("RhythRicoTempScore");

        print(currentScore);

        if (Input.GetKey(KeyCode.Escape))
        {
            SceneManager.LoadScene("GameOver");
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

        else if (health <= 0)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("GameOver");
        }
    }
}
