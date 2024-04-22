using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]//zorgt ervoor dat er een Rigidbody2d is omdat dat in deze script wordt gebruikt

public class movement : MonoBehaviour
{
    [SerializeField] float jumpforce = 6.5f;// een float voor de jumpforce van mijn player / hoe hoog hij kan springen
    Rigidbody2D rb;// een rigidbody2d voor de player zodat hij niet in de lucht blijft hangen
    float Speed = 5f;// een float voor de snelheid van de player / hoe snel de speler kant lopen
    public float HorizontalInput; // een public float voor de horizontale input wat dus a en d is
    public bool canJump = true; // een bool dat checkt of je kan springen
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");// zet horizontalinput naat de axis van horizontal

        rb.velocity = new Vector2(HorizontalInput * Speed, rb.velocity.y);//zet de velocity van de rigidbody naar een nieuwe vector2 met input van horizontalinput maal sppen en de rigibody velocity Y waarde
        if (Input.GetKeyDown(KeyCode.Space) && canJump == true)// als de key space wordt ingedrukt en canjump is true
        {
            rb.AddForce(Vector2.up * jumpforce, ForceMode2D.Impulse);// adds de force van vector2.up maal jumpfore met een forcemod2d wat een impulse is
            canJump = false;//zet canjump op false
        }
    }
}
