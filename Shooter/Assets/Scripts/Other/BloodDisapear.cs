using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloodDisapear : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Disappear());
    }

    private IEnumerator Disappear()
    {
        yield return new WaitForSeconds(10f);
        Destroy(gameObject);
    }
}
