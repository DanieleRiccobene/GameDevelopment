using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBullet : MonoBehaviour
{
    [SerializeField] int damage;

    public void SetBulletType(int damageAmount)
    {
        damage = damageAmount;
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGER");
        if(other.gameObject.layer==8)
        {
            Debug.Log("COLPITO");
            other.gameObject.GetComponent<Enemy>().Hit(damage);
            gameObject.SetActive(false);
        }
    }
}
