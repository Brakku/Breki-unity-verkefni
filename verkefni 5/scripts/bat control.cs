using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class batcontrol : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    Vector2 move;

    //tick fyrir upp/niður hreifing
    int tick = 0;
    
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }


     void FixedUpdate()
    {

        // hreifa upp/niður
        if (tick < 20){
            move.y = 1;
        }
        else {
            move.y = -1;
        }
        Vector2 position = rigidbody2d.position + move * Time.deltaTime;
        rigidbody2d.MovePosition(position);
        tick +=1;
        if (tick == 40){
            tick = 0;
        }
    }
}
