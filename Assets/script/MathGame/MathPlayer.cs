using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MathPlayer : MonoBehaviour
{
    [SerializeField] float rotationSpeed = 100f;
    [SerializeField] GameObject bullet;
    public Transform bulletStart;
    public Transform bulletEnd;
    LineRenderer line;
    public bool canShoot = true;
    private void Start()
    {
        line = GetComponent<LineRenderer>();
    }
    void Update()
    {
        float rotate = Input.GetAxis("Horizontal"); // geeft de float een waarde van de horizontale input        
        transform.Rotate(new Vector3(0, 0, -1) * rotate * Time.deltaTime * rotationSpeed); //rotate het object 

        if (Input.GetKeyDown(KeyCode.Space) && canShoot) // als de spatiebalk op het toetsenbord naar beneden gedrukt is en de andere conditie ook klopt run dan de code
        {
           Instantiate(bullet,bulletStart.position,Quaternion.identity); // spawnt een bullet op een specifieke positie
        }
    }
    private void FixedUpdate()
    {
       line.SetPosition(0,bulletStart.position); // zet het begin van de linderenderer op een positie
       line.SetPosition(1,bulletEnd.position); // zet de 2de positie van de linerenderer op een positie
    }
}
