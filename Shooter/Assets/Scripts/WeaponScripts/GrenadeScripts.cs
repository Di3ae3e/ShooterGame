using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeScripts : MonoBehaviour
{
    public GameObject Effect;
    public int explosionPower;
    //public float explosionTime;

    private void Start() 
    {
        StartCoroutine(Explosion());
        StartCoroutine(Delete());
    }
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.tag == "Player")
        {
            Debug.Log("Нанесен урон по игроку"); // скрипт урона 
            Destroy(gameObject);
        }
        else if(other.gameObject.tag == "Enemy")
        {
            Debug.Log("Нанесен урон по врагу"); // тут нужно вставить скрипт урона 
            Destroy(gameObject);
        }
    }
    private IEnumerator Explosion()
    {
        yield return new WaitForSeconds(5f);
        GetComponent<CircleCollider2D>().enabled = true;
        Effect.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
        Instantiate(Effect);
    }
    private IEnumerator Delete()
    {
        yield return new WaitForSeconds(5.01f);
        Destroy(gameObject);
    }
}
