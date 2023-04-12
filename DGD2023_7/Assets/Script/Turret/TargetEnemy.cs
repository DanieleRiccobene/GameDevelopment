using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetEnemy : MonoBehaviour
{
    [SerializeField] GameObject target;
    [SerializeField] GameObject turret;
    // Update is called once per frame
    void Update()
    {
        //EnemyManager.instance.DoSomething();
        if (target != null)
        {
            turret.transform.LookAt(target.transform);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            target = other.gameObject;
            GetComponent<MachineGun>().StartShootingCoroutine();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.layer == 8)
        {
            target = null;
            GetComponent<MachineGun>().StopShootingCoroutine();
        }
    }
}
