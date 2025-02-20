using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Push : MonoBehaviour
{

    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }


    void Update()
    {
       if (Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(2, 0);
        }
      
    }

}
