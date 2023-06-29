using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Exitscript : MonoBehaviour
{
    public TMP_Text message;
    public Image curtain;
    private GameObject[] gameObjects;
    private void Start() 
    {
        gameObjects = GameObject.FindGameObjectsWithTag("Enemy");
    }
    void Update() 
    {
        if (gameObjects.Length == 0)
        {
            curtain.enabled = true;
            Debug.Log("Cock");
        }
    }
    void OnCollisionEnter2D(Collision2D other) 
    {
        if(other.collider.CompareTag("Player") && gameObjects.Length > 0)
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
