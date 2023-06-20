using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    public float attackRotateSpeed;
    public float speedAttack;
    public Transform target;

    public EnemyPatrol patrolScript;
    public Transform enemyPosition;

    private void Update()
    {
        RotateToPlayer();
    }

    public void RotateToPlayer()
    {
        if(patrolScript.enabled == false)
        {
            Vector2 movementDiretcion = Vector2.MoveTowards(enemyPosition.position, target.position, speedAttack * Time.deltaTime);
            enemyPosition.position = movementDiretcion;

            Vector3 targetDir = target.position - enemyPosition.position;
            float angle = Mathf.Atan2(targetDir.y, targetDir.x) * Mathf.Rad2Deg - 90;
            Quaternion q = Quaternion.AngleAxis(angle, Vector3.forward);
            enemyPosition.rotation = Quaternion.Slerp(enemyPosition.rotation, q, attackRotateSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            patrolScript.enabled = false;
        }
    }
}
