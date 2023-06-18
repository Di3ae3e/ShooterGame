using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightGrenade : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(Light());
    }
    private IEnumerator Light()
    {
        yield return new WaitForSeconds(4.9f);
        GetComponent<Light>().enabled = true;
    }
}
