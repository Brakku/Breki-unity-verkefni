using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
   Rigidbody2D rigidbody2d;


   // allt tekið frá verkefni 4
   void Awake()
   {
       rigidbody2d = GetComponent<Rigidbody2D>();
   }

   void Update()
   {
       if(transform.position.magnitude > 100.0f)
       {
           Destroy(gameObject);
       }
   }


   public void Launch(Vector2 direction, float force)
  {
       rigidbody2d.AddForce(direction * force);
  }


   private void OnCollisionEnter2D(Collision2D other)
  {
       
        Destroy(other.gameObject);
        Destroy(rigidbody2d.gameObject,0.1f);

       
  }

}