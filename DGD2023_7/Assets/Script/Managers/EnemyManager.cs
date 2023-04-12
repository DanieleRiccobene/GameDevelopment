using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyManager : MonoBehaviour
{
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject[] enemyList;
    [SerializeField] int enemyLength;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float timeToSpawn;
    int enemyCounter;
    float timer = 0;
    public static EnemyManager instance;
    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
        enemyList = new GameObject[enemyLength];
        for(int i=0; i<enemyLength; i++)
        {
            enemyList[i] = Instantiate(enemy, spawnPoint.position, spawnPoint.rotation);
            enemyList[i].SetActive(false);
        }
        enemyCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeToSpawn)
        {
            SpawnEnemy();
        }
    }

    void SpawnEnemy()
    {
        timer = 0;
        for(int i=enemyCounter; i<enemyLength; i++)
        {
            if(!enemyList[i].activeInHierarchy)
            {
                enemyList[i].GetComponent<Enemy>().Spawn(spawnPoint);
                enemyCounter = i + 1;
                if(enemyCounter>=enemyLength)
                {
                    enemyCounter = 0;
                }
                break;
            }
        }
    }

    public void DoSomething()
    {
        Debug.Log("Sono un lazy singleton");
    }
}
