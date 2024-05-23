using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class flippers : MonoBehaviour
{
    public int id;
    private float speed = 10f;
    [SerializeField] Transform target1;
    [SerializeField] Transform target2;
    private void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            if (id == 1) transform.rotation = Quaternion.Lerp(transform.rotation, target1.rotation, Time.deltaTime * speed);
            else if (id == 2) transform.rotation = Quaternion.Lerp(transform.rotation, target2.rotation, Time.deltaTime * speed);
        }
    }
    //public List<float> toPos;
    //private int counter = 1;
    //private int counter2 = 0;
    //private int counter3 = 19;
    //private bool done = false;
    //private bool goDown = false;

    //void Update()
    //{
    //    if (counter2 == 20) counter2 = 19;
    //    if (counter3 == -1) counter3 = 0;

    //    if (!done)
    //    {
    //        int toAdd = 20 - counter;
    //        toPos.Add(toAdd);
    //        counter--;
    //        if (toAdd == 40) done = true;
    //    }

    //    if (Input.GetKey(KeyCode.Space))
    //    {
    //        if (id == 1) transform.rotation = Quaternion.Euler(0, 0, toPos[counter2]);
    //        else if (id == 2) transform.rotation = Quaternion.Euler(0, 0, -toPos[counter2]);
    //        if (counter2 <= 19)
    //        {
    //            counter2++;
    //        }
    //        goDown = false;
    //    }

    //    if (Input.GetKeyUp(KeyCode.Space))
    //    {
    //        goDown = true;
    //        counter2 = 0;
    //        counter3 = 19;
    //    }

    //    if (goDown)
    //    {
    //        if (id == 1) transform.rotation = Quaternion.Euler(0, 0, toPos[counter3]);
    //        else if (id == 2) transform.rotation = Quaternion.Euler(0, 0, -toPos[counter3]);
    //        if (counter3 >= 0)
    //        {
    //            counter3--;
    //        }
    //    }
    //}
}
