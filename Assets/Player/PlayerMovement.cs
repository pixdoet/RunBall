using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    // vars
    public float speed = 1000f;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        // for physics use FixedUpdate!!!!
        // zamn i wish i can use python for unity

        // add player input (use switch case)
        
    }
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }
        if (Input.GetKey("s"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey("d"))
        {
            rb.AddForce(speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("space"))
        {
            rb.AddForce(0, speed * Time.deltaTime, 0);
        }
        if (Input.GetKey("left shift"))
        {
            rb.AddForce(0, -speed * Time.deltaTime, 0);
        }
        // rb.AddForce(0,0,speed * Time.deltaTime);
    }
}
