using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    [SerializeField] GameObject Vischaca;
    float time = 0f;
    float duration = 10f;
    // Start is called before the first frame update
    void Start()
    {
        Vischaca.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))//checkt of de key space wordt ingedrukt
        {
            SceneManager.LoadScene("HubWorld");//laadt de scene HubWorld
        }
        time += Time.deltaTime;
        if(time > duration)
        {
            time = 0f;
            Vischaca.SetActive(true);
        }

    }
    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
    }
}
