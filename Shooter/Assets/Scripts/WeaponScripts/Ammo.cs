using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    // public float speed;
    // public float distance;
    // public int damage;
    // public GameObject bloodSplash;
    // public GameObject destroyEffect;
    // public LayerMask layerMask;
    // public int destroy;
    
    // void Update()
    // {
    //     RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance);
    //     if(other.collider !=null)
    //     {
    //         if (other.collider.CompareTag("Enemy"))
    //         {
    //            other.collider.GetComponent<Enemy>().TakeDamage(damage);
    //             Destroy(gameObject);
    //         }

    //         if (other.collider.CompareTag("Wall"))
    //         {
    //             Destroy(gameObject);
    //         }
    //     }
    //     transform.Translate(Vector2.up * speed * Time.deltaTime);
    // }

    // void Destroy()
    // {
    //     Instantiate(destroyEffect, transform.position, Quaternion.identity);
    //     Instantiate(bloodSplash, transform.position, Quaternion.identity);
    //     Destroy(gameObject);
    // }
    // void DestroyTime()
    // {
    //     Destroy(gameObject);
    // }
    // void Start()
    // {
    //     Invoke("DestroyTime", destroy);
    // }
}
