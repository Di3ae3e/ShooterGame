using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exitscript : MonoBehaviour
{
    public TMP_Text message;

    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.CompareTag("Player"))
        {
            message.text = "Вы не завершили задание";
            StartCoroutine(TextVanish());
        }
    }
    private IEnumerator TextVanish()
    {
        if(message.text == "Вы не завершили задание")
        {
            yield return new WaitForSeconds(5f);
            message.text = " ";
        }
    }
}
