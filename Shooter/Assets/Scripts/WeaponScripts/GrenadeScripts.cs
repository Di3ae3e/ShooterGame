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
    public GameObject AudioEmpty;
    public float distance;
    public float speed;
    public int explosionPower;
    public float damage = 20f;

    private void Start() 
    {
        StartCoroutine(Explosion());
        StartCoroutine(Delete());
        StartCoroutine(Light());
    }
    void Update() 
    {
        RaycastHit2D other = Physics2D.Raycast(transform.position, transform.up, distance);
            if(other.collider !=null)
            {
                if (other.collider.CompareTag("Enemy"))
                {
                    speed = 0f;
                }
                else if (other.collider.CompareTag("Wall"))
                {
                    speed = 0f;
                }
         }
        transform.Translate(Vector2.up * speed * Time.deltaTime);    
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
        AudioEmpty.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(AudioEmpty);
    }
    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(5.1f);
        Destroy(gameObject);
    }
}
