using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocket : MonoBehaviour
{
    public float boost = 150;
    public float rotation = 10;
    bool up = false;
    bool left = false;
    bool right = false;

    Rigidbody rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputs();
        boosting();
        rotations();
    }

    void inputs(){
        if(Input.GetKeyDown(KeyCode.Space))
        { 
           up = true; 
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            left = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            right = true;
        }
    }

    void boosting(){
        if (up)
        {
            rigidbody.AddRelativeForce(Vector3.up * boost, ForceMode.Acceleration);    
            up = false;
        }
    }

    void rotations(){
        if(left)
        {
            transform.Rotate(0,0,rotation);
            left = false;    
        }
        
        if(right)
        {
            transform.Rotate(0, 0, -rotation);
            right = false;
        }
        
    }
}
