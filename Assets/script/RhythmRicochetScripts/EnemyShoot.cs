using System.Collections;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform enemyPos;
    [SerializeField] GameObject Bullet;

    Transform spawnBullet;
    void Start()
    {
        spawnBullet = this.gameObject.transform.GetChild(0); //pakt een gameobject child van het gameobject waar dit script op zit
        transform.up = playerPos.position - transform.position; //zet de rotatie van de enemy richting de player
        StartCoroutine(SpawnBullet()); //start de coroutine om bullets te spawnen
    }

    IEnumerator SpawnManager() //buffer Coroutine om ervoor te zorgen dat er geen loop ontstaat die heel unity crashed
    {
        yield return new WaitForSeconds(1);
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(0);
        Instantiate(Bullet, spawnBullet.position, Quaternion.identity); //spawnt een bullet op de locatie van de spawner gameobject die is geparent aan de enemy
        StartCoroutine(SpawnManager());
    }
}
