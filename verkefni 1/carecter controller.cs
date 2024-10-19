using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class playercontroler : MonoBehaviour
{
    void Start()
    {

    }

    // þar sem variable eru assigned
    public float horizontalInput;
    public float verticalInput;
    public float speed = 20f;
    void Update()
    {
        // þar sem inputtin eru tekin inn
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical"); 

        // þar sem bíllin er breittur
        transform.Translate(Vector3.forward * Time.deltaTime * speed * verticalInput);
        transform.Rotate(Vector3.up, horizontalInput);
    }
}