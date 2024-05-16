using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class flippers : MonoBehaviour
{
    public int id;
    public List<float> toPos;
    private int counter = 1;
    private int counter2 = 0;
    private int counter3 = 74;
    private bool done = false;
    private bool goDown = false;

    void Update()
    {
        if (counter2 == 75) counter2 = 74;
        if (counter3 == -1) counter3 = 0;

        if (!done)
        {
            int toAdd = 55 + counter;
            toPos.Add(toAdd);
            counter++;
            if (toAdd == 130) done = true;
        }

        if (Input.GetKey(KeyCode.Space))
        {   
            if (id == 1) transform.rotation = Quaternion.Euler(0, 0, toPos[counter2]);
            else if (id == 2) transform.rotation = Quaternion.Euler(0, 0, -toPos[counter2]);
            if (counter2 <= 74)
            {
                counter2++;
            }            
            goDown = false;
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            goDown = true;
            counter2 = 0;
            counter3 = 74;
        } 

        if (goDown)
        {
            if (id == 1) transform.rotation = Quaternion.Euler(0, 0, toPos[counter3]);
            else if (id == 2) transform.rotation = Quaternion.Euler(0, 0, -toPos[counter3]);
            if (counter3 >= 0)
            {
                counter3--;
            }           
        }
    }
}
