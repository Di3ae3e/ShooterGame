using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCoroutine : MonoBehaviour
{
    private int i = 0;
    void Start()
    {
	    StartCoroutine(TestCoroutine1());
    }

    IEnumerator TestCoroutine1()
    {   
	    while(true)
	    {
		    yield return new WaitForSeconds(5f);
		    Debug.Log(i++);
	    }
    }
}