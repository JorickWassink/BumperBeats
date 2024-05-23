using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class flippers : MonoBehaviour
{
    public int id;
    private float speed = 25f;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    [SerializeField] Transform start1;
    [SerializeField] Transform start2;
    bool holdingSpace = false;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            holdingSpace = true;
            if (id == 1) transform.rotation = Quaternion.Lerp(transform.rotation, target1.rotation, Time.deltaTime * speed);
            else if (id == 2) transform.rotation = Quaternion.Lerp(transform.rotation, target2.rotation, Time.deltaTime * speed);
        }
        else
        {
            holdingSpace = false;
        }
        
        if (!holdingSpace)
        {
            if (id == 1) transform.rotation = Quaternion.Lerp(transform.rotation, start1.rotation, Time.deltaTime * speed);
            else if (id == 2) transform.rotation = Quaternion.Lerp(transform.rotation, start2.rotation, Time.deltaTime * speed);
        }
    }
}
