using System.Collections;
using UnityEngine;

public class EnemyThing : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform enemyPos;
    [SerializeField] GameObject Bullet;
    void Start()
    {
        transform.up = playerPos.position - transform.position;
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(2);
        Instantiate(Bullet, transform.position, Quaternion.identity);
    }
}
