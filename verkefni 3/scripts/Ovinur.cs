using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using UnityEngine.UI;


public class Ovinur : MonoBehaviour
{

    // tekið af innu en mikið hefur verið fært annarstaðar
    private Transform player;
    private Rigidbody rb;
    private Vector3 movement;
    public float hradi = 5f;
    void Start()
    {

        rb = this.GetComponent<Rigidbody>();
        player = GameObject.Find("Capsule Mesh").transform;
        
    }

    void Update()
    {
        Vector3 stefna = player.position - transform.position;
        stefna.Normalize();
        movement = stefna;
    }
    private void FixedUpdate()
    {
        Hreyfing(movement);
    }
    void Hreyfing(Vector3 stefna)
    {
        rb.MovePosition(transform.position + (stefna * hradi * Time.deltaTime));
    }
    
    

}
