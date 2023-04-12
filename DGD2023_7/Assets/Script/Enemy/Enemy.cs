using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] protected float speed;
    [SerializeField] protected float rotationSpeed;
    [SerializeField] protected int coins;
    [SerializeField] protected float maxHealth;
    [SerializeField] protected float health;
    [SerializeField] protected Transform[] checkPoints;
    [SerializeField] protected Transform target;
    private int targetIndex = 0;

    private void Awake()
    {
        TakeCheckPoints();
    }
    public void Spawn(Transform spawnPoint)
    {
        transform.Spawn(spawnPoint);
    }

    protected virtual void Init()
    {
        Debug.Log("Sono l'init di enemy");
    }

    protected virtual void Start()
    {
        Init();
        StartCoroutine(RotateToTarget());
    }

    private void OnEnable()
    {
        health = maxHealth;
    }

    public void Hit(float damage)
    {
        health -= damage;
        Debug.Log(health);
        if (health <= 0)
        {
            CoinManager.instance.AddCoins(coins);
            gameObject.SetActive(false);
        }
    }

    protected void TakeCheckPoints()
    {
        GameObject aux = GameObject.Find("CheckPoints");
        checkPoints = new Transform[aux.transform.childCount];
        for(int i=0; i < checkPoints.Length; i++)
        {
            checkPoints[i] = aux.transform.GetChild(i);
        }
        target = checkPoints[targetIndex];
    }

    IEnumerator RotateToTarget()
    {
        Vector3 direction;
        Quaternion lookRotation;
        while (true)
        {
            direction = target.position - transform.position;
            lookRotation = Quaternion.LookRotation(direction);
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * rotationSpeed);
            yield return 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.layer==11)
        {
            target = checkPoints[++targetIndex];
        }
    }
}
