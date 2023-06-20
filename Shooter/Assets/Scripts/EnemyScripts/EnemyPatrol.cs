using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class EnemyPatrol : MonoBehaviour
{
    public float speedPatrol;
    public float rotateSpeed;

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
        Vector2 movementDiretcion = Vector2.MoveTowards(transform.position, moveSpot[randomSpot].position, speedPatrol * Time.deltaTime);
        transform.position = movementDiretcion;

        //Quaternion toRotation = Quaternion.LookRotation(Vector3.forward, movementDiretcion);
        //transform.rotation = Quaternion.RotateTowards(transform.rotation, toRotation, rotateSpeed * Time.deltaTime);

        Vector3 targetDir = moveSpot[randomSpot].position - transform.position;
        float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90;
        Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
        transform.rotation = Quaternion.Slerp(transform.rotation, q, rotateSpeed * Time.deltaTime);


        if (Vector2.Distance(transform.position, moveSpot[randomSpot].position) < 0.2f)
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
