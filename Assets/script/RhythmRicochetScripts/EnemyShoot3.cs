using System.Collections;
using UnityEngine;

public class EnemyShoot3 : MonoBehaviour
{
    //dit script is ook fundementeel hetzelfde als EnemyShoot
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
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(0);
        Instantiate(Bullet, spawnBullet.position, Quaternion.identity);
        StartCoroutine(SpawnManager());
    }
}
