using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    public GameObject balBreakout; //Een gameobject
    // Start is called before the first frame update
    void Start()
    {
        balBreakout = GameObject.FindGameObjectWithTag("Ball");//De gameobject is nu de object met tag van Ball
    }
    private void OnTriggerEnter2D(Collider2D collision)//Een class voor als een object iets aanraakt
    {
        if (collision.tag == "bumperBreakout") //Als je bumperBreakout aanraakt dan gebeurt dit
        {
            GameObject balClone = Instantiate(balBreakout); //Er wordt een clone gemaakt van de bal
            //De clone krijgt een nieuwe positie
            balClone.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Destroy(gameObject);//Destroyed de gameobject
        }

        if (collision.tag == "YouLose") //Als je De rode lijn aanraakt gebeurt dit
        {
            Destroy(gameObject);//Destroyed de gameobject
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
