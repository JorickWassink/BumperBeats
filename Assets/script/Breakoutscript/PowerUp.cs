using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    GameObject bal;
    // Start is called before the first frame update
    void Start()
    {
        bal = GameObject.FindGameObjectWithTag("Ball");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "bumperBreakout") //Als je de powerup aanraakt dan gebeurt dit
        {
            GameObject balClone = Instantiate(bal);
            balClone.transform.position = new Vector3 (transform.position.x, transform.position.y, transform.position.z);
            Destroy(gameObject);//Destroyed de gameobject van powerup
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
