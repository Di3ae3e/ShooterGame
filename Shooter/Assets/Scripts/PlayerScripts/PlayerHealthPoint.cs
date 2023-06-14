using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthPoint : MonoBehaviour
{
    public float maxHp;
    [HideInInspector]static public float hp;
    float scaleHp;

    public Image hpImage;

    private void Start()
    {
        hp = maxHp;
    }

    private void Update()
    {
        scaleHp = hp / maxHp;
        hpImage.fillAmount = scaleHp;
        if(scaleHp <= 0)
        {
            Destroy(gameObject);
        }
    }
}
