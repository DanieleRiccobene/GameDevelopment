using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingTurret : MainTurret
{
    [SerializeField] GameObject bullet;
    [SerializeField] GameObject[] bulletList;
    [SerializeField] int bulletLength;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float timeToSpawn;
    
    int bulletCounter = 0;
    // Start is called before the first frame update
    void Awake()
    {
        bulletList = new GameObject[bulletLength];
        for (int i = 0; i < bulletLength; i++)
        {
            bulletList[i] = Instantiate(bullet);
            bulletList[i].GetComponent<HitBullet>().SetBulletType((int)myTurret);
        }
    }

    IEnumerator Shoot()
    {
        while (true)
        {

            yield return new WaitForSeconds(timeToSpawn);
            SpawnBullet();
        }
    }

    public void StartShootingCoroutine()
    {
        StartCoroutine(Shoot());
    }

    public void StopShootingCoroutine()
    {
        StopCoroutine(Shoot());
    }

    void SpawnBullet()
    {
        bulletList[bulletCounter++].GetComponent<Bullet>().Spawn(spawnPoint);
        if (bulletCounter == bulletLength)
        {
            bulletCounter = 0;
        }
        /*
        for(int i=0; i<bulletLength; i++)
        {
            var bulletAux = bulletList[bulletCounter];
            if (!bulletAux.activeInHierarchy)
            {

            }
            else
            {

            }
        }
        */
    }
}
