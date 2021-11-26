using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float thrust;
    float rotation;
    private bool boosting = false;
    Rigidbody rocket;
    private Vector3 force;

    void Start()
    {
        rocket = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        Inputs();
        ApplyThrust();
    }

    void Inputs()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            boosting = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localRotation = Quaternion.Euler(0,0,10);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
           transform.localRotation = Quaternion.Euler(0,0,-10);
        }
        else {transform.localRotation = Quaternion.Euler(0,0,0);}
    }

    void ApplyThrust()
    {
        thrust = 20;
        rotation = Input.GetAxis("Horizontal") * 5;
        force = new Vector3(rotation, thrust);

        if (boosting)
        {
            rocket.AddForce(force, ForceMode.Acceleration);
            boosting = false;
        }
    }
}
