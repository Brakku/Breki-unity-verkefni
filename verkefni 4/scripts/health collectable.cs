using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class healthCollectible : MonoBehaviour
{

public AudioClip collectedClip;
void OnTriggerEnter2D(Collider2D other)
{
   PlayerController controller = other.GetComponent<PlayerController>();


   if (controller != null && controller.health< controller.maxHealth)
   {
       controller.ChangeHealth(1);
       controller.PlaySound(collectedClip);
       Destroy(gameObject);
   }
}
}