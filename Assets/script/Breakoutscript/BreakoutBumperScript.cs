using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakoutBumperScript : MonoBehaviour
{
    float horizontal; //Een float voor horizontale beweging van de bumper
    Rigidbody2D player; //De rigidbody
    [SerializeField] float speed = 12f; //De float speed staat op 12f

    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>(); //Hij zoekt of de gameobject een rigidbody heeft en zet die als rb
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "PowerUp") //Als je de powerup aanraakt dan gebeurt dit
        {
            Destroy(collision.gameObject);//Destroyed de gameobject van powerup

        }
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal"); //Hij zoekt bij input manager de horizontal.
        player.velocity = new Vector2(horizontal * speed, 0);

        if (transform.position.x <= -8.714)//Als de position van de x kleiner of gelijk is aan -8.714 dan gebeurt dit
        {
            transform.position = new Vector3(-8.714f, transform.position.y, 0);//De positie wordt veranderd naar wat er tussen de haakjes staat.
        }

        if (transform.position.x >= 8.42)//Als de position van x groter of gelijk is aan 8.42
        {
            transform.position = new Vector3(8.42f, transform.position.y, 0); //De positie van x, y en z wordt veranderd/
                                                                              //naar wat er tussen de haakjes staat.
        }
    }
}
