using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GrenadeThrow : MonoBehaviour
{
    public Transform projectileTransform;
    public GameObject HG;
    public int Grenades;
    public TMP_Text counter;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && Grenades > 0)
        {
            //HG.transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            Instantiate(HG, projectileTransform.position, transform.rotation);
            Grenades--;
        }
        counter.text = " " + Grenades;
    }
}
