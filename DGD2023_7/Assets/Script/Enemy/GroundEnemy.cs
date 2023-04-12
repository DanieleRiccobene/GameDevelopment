using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundEnemy : Enemy
{
    protected override void Init()
    {
        base.Init();
        Debug.Log("Sono l'init di ground enemy");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
    }
}
