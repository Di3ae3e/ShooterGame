using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    public float speedPatrol;
    private float waitTime;
    public float startWaitTime;

    public Transform[] moveSpot;
    private int randomSpot;

    private void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, moveSpot.Length);
    }

    private void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, moveSpot[randomSpot].position, speedPatrol * Time.deltaTime);
        if(Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, moveSpot.Length);
                waitTime = startWaitTime;
            }
            else
            {
                waitTime -= Time.deltaTime;
            }
        }
    }
}
