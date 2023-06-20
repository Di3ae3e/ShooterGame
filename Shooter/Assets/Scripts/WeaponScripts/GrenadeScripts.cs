using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GrenadeScripts : MonoBehaviour
{
    public GameObject Effect;
    public GameObject SmokeEffect;
    public GameObject lighting;
    public GameObject burn;
    public int explosionPower;
    public float damage = 20f;
    
    //public float explosionTime;

    private void Start() 
    {
        StartCoroutine(Explosion());
        StartCoroutine(Delete());
        StartCoroutine(Light());
    }

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player")
        {
            PlayerHealthPoint.hp -= damage;
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Enemy")
        {
            Enemy.hp -= damage;
            Destroy(gameObject);
        }
    }
    
    private IEnumerator Light()
    {
        yield return new WaitForSeconds(4.9f);
        lighting.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(lighting);
    }

    private IEnumerator Explosion()
    {
        yield return new WaitForSeconds(5f);
        GetComponent<CircleCollider2D>().enabled = true;
        Effect.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(Effect);
        SmokeEffect.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(SmokeEffect);
        burn.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(burn);
    }
    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(5.1f);
        Destroy(gameObject);
    }
}
