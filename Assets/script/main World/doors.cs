using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{

    [SerializeField] Transform playertransform;
    [SerializeField] coins coins;
    // Start is called before the first frame update
    void Start()
    {
     
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player") && playertransform.position == new Vector3(7.914441f, 2.11f, 0))// deze is voor coins
        {
            SceneManager.LoadScene("Jorick");
        }
        if(collision.CompareTag("Player") && playertransform.position == new Vector3(14.5f, 5.421f, 0))// dit is voor eerste game
        {
            coins.removecoin();
            SceneManager.LoadScene("Sam");
        }


    }
    public void ReturnCoinsDoor()
    {
        SceneManager.LoadScene("Leon");
        playertransform.position = new Vector3(10, 1.5748f, 0);
    }
}
