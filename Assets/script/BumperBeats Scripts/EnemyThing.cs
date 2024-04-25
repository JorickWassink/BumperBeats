using System.Collections;
using UnityEngine;

public class EnemyThing : MonoBehaviour
{
    [SerializeField] Transform playerPos;
    [SerializeField] Transform enemyPos;
    [SerializeField] GameObject Bullet;
    public int BulletCount = 0;
    void Start()
    {
        transform.up = playerPos.position - transform.position;
        StartCoroutine(SpawnBullet());
    }

    IEnumerator SpawnBullet()
    {
        yield return new WaitForSeconds(Random.Range(0f,3f));
        Instantiate(Bullet, transform.position, Quaternion.identity);
        BulletCount++;
    }
}
