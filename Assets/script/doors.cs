using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class doors : MonoBehaviour
{
    public int doorIndex;
    public bool getCoinsDoor;
    public bool MainGameDoor;
    public bool pinballDoor;
    [SerializeField] Transform playertransform;

    // Start is called before the first frame update
    void Start()
    {
        doorIndex = -1;
        getCoinsDoor = false;
        MainGameDoor = false;
        pinballDoor = false;
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player") && transform.position == new Vector3(8, 2.07f, 0))
        {
            getCoinsDoor = true;
            playertransform.position = new Vector3 (6, 1.5748f, 0);
        }
        if(collision.CompareTag("Player") && transform.position == new Vector3(14.5f, 5.421f, 0))
        {
            MainGameDoor = true;
        }
        if (collision.CompareTag("Player") && getCoinsDoor == true)
        {
            SceneManager.LoadScene("Jorick");
        }
        if (collision.CompareTag("Player") && MainGameDoor == true)
        {
            SceneManager.LoadScene("Sam");
        }
    }
}
