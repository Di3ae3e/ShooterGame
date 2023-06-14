using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    public GameObject HG;
    public int Grenades;
    public float speed;
    public float distance;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && Grenades > 0)
        {
            HG.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Grenades--;
            Instantiate(HG);
        }
    }
}
