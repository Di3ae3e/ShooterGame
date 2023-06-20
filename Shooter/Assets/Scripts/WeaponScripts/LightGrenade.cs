using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGrenade : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(LightDestroy());
    }
    private IEnumerator LightDestroy()
    {
        yield return new WaitForSeconds(0.3f);
        Destroy(gameObject);
    }
}
