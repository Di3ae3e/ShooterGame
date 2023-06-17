using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float maxHp;
    [HideInInspector] static public float hp;

    private void Start()
    {
        hp = maxHp;
    }

    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
