using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;

public class MathPlayer : MonoBehaviour
{
    Vector2 moveDirection;
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
        float rotate = Input.GetAxis("Horizontal");        
        transform.Rotate(new Vector3(0, 0, -1) * rotate * Time.deltaTime * rotationSpeed);

        if (Input.GetKeyDown(KeyCode.Space) && canShoot)
        {
           Instantiate(bullet,bulletStart.position,Quaternion.identity);
        }
    }
    private void FixedUpdate()
    {
       line.SetPosition(0,bulletStart.position);
       line.SetPosition(1,bulletEnd.position);
        
    }
}
