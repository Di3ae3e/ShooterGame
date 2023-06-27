using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class WeaponShoot : MonoBehaviour
{
     public GameObject projectile;
     public Transform projectileTransform;
     public TMP_Text ammunition;
     public TMP_Text ReloadText;
     public int mag;
     private int ammo;
     public float StartTimeFire;
     private float TimeFire;
     

     private AudioSource audioSource;

     void Start()
     {  
         ammo = mag;
         TimeFire = StartTimeFire;
         audioSource = GetComponent<AudioSource>();
     }

     void Update()
     {
         if(Input.GetKey(KeyCode.Mouse0) && ammo > 0)
         {
            if(TimeFire <= 0)
            {
                 Instantiate(projectile, projectileTransform.position, transform.rotation);
                 // audioSource.Play();
                 TimeFire = StartTimeFire;
                 ammo -- ;
            } 
             else
             {
                 TimeFire -=Time.deltaTime;
             }
         }
         if(Input.GetKey(KeyCode.R))
         {
            ammunition.enabled = false;
            ReloadText.enabled = true;
            ammo = 0;
            StartCoroutine(Reloading());
         }
         
         ammunition.text = mag + "/" + ammo;
     }
     private IEnumerator Reloading()
     {
        yield return new WaitForSeconds(3f);
        ammo = mag;
        ReloadText.enabled = false;
        ammunition.enabled = true;
     }
}
