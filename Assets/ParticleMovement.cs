using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleMovement : MonoBehaviour
{

    private DateTime startTime;
    // Start is called before the first frame update
    void Start()
    {
        startTime = DateTime.Now;
        //Do somthing with this to have controlled velocity with no dependence on fps
        //Debug.Log("");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            GetComponent<Rigidbody>().velocity = new Vector3(0, 5, 0);
        }
        if (Input.GetKey("w"))
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + new Vector3(-0.03f, 0, 0.03f);
        }
        if (Input.GetKey("a"))
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + new Vector3(-0.03f, 0, -0.03f);
        }
        if (Input.GetKey("s"))
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + new Vector3(0.03f, 0, -0.03f);
        }
        if (Input.GetKey("d"))
        {
            GetComponent<Rigidbody>().velocity = GetComponent<Rigidbody>().velocity + new Vector3(0.03f, 0, 0.03f);
        }
    }
}
