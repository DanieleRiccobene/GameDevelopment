using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    // Start is called before the first frame update
    public void Spawn(Transform spawnPoint)
    {
        transform.Spawn(spawnPoint);

    }
}
