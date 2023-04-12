using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionClass : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        foreach (ContactPoint contact in collision.contacts)
        {
            Debug.Log("Collisione");
            Debug.DrawRay(contact.point, contact.normal, Color.red, 2000);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        //EnemyManager.instance.DoSomething();
        Debug.Log("Trigger Collision");
        if (other.gameObject.layer == 8)
        {
            /*
            if(other.gameObject.tag=="NomeTag")
            {

            }
            */
            Debug.Log("Do Something");
        }
    }
}
