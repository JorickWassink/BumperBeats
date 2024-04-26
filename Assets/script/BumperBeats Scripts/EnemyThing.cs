using System.Collections;
using UnityEngine;

public class EnemyThing : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform enemyPos;
    [SerializeField] GameObject Bullet;

    Transform spawnBullet;
    void Start()
    {
        spawnBullet = this.gameObject.transform.GetChild(0);
        transform.up = playerPos.position - transform.position;
        StartCoroutine(SpawnBullet());

    }

    IEnumerator SpawnManager()
    {
        yield return new WaitForSeconds(2);
        StartCoroutine(SpawnBullet());
    }
    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(Random.Range(0f, 3f));
        Instantiate(Bullet, spawnBullet.position, Quaternion.identity);
        StartCoroutine(SpawnManager());
    }
}
