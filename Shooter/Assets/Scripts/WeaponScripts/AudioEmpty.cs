using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioEmpty : MonoBehaviour
{
    private AudioSource explosionSFX;
    void Awake()
    {
        explosionSFX = GetComponent<AudioSource>();
        StartCoroutine(Destroy());
    }
    void Start()
    {
        explosionSFX.Play();
    }
    private IEnumerator Destroy()
    {
        yield return new WaitForSeconds(4f);
        Destroy(gameObject);
    }
}
