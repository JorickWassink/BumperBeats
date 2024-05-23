using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    [SerializeField] GameObject Vischaca;// gameobject met de naam vischaca
    float time = 0f;//float met de naam time dat als value 0f heeft
    float duration = 10f;//float met de naam duration dat als value 10f heeft
    // Start is called before the first frame update
    void Start()
    {
        Vischaca.SetActive(false);//zet de gameobject active op false zodat het niet tezien is in de scene
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//checkt of de key space wordt ingedrukt
        {
            SceneManager.LoadScene("HubWorld");//laadt de scene HubWorld
        }
        time += Time.deltaTime;//voegt time.deltatime toe aan time
        if(time > duration)// checkt of time groter is dan duration
        {
            time = 0f;//zet time naar 0f
            Vischaca.SetActive(true);//zet de gameobject active op true zodat het tezien is in de scene
        }

    }
}
