using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBullet : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitForCoroutine());
    }

    IEnumerator Shoot()
    {
        Debug.Log("Prima");
        yield return new WaitForSeconds(3);
        Debug.Log("Dopo");

    }

    IEnumerator NewUpdate()
    {
        while (true)
        {
            //Do something
            Debug.Log("Sono un update diverso");
            yield return 0;
        }
    }

    IEnumerator WaitForCoroutine()
    {
        Debug.Log("Entro nella coroutine Wait For Coroutine");
        yield return StartCoroutine(Test(6));
        Debug.Log("Esco dalla coroutine Wait");
    }

    IEnumerator Test(int timeToWait)
    {
        Debug.Log("Entro nella coroutine Test");
        yield return new WaitForSeconds(timeToWait);
        Debug.Log("Esco dalla coroutine Test");
    }
}
