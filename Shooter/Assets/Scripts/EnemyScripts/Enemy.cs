using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int Health ;
    public GameObject destroyEffect;
    
    void Update()
    {
        if (Health <=0)
        {
            Instantiate(destroyEffect,transform.position, Quaternion.identity);
            
            Destroy(gameObject);
        }
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;
    }
}
