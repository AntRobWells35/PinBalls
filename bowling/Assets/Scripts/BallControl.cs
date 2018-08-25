using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    public float speed;  
 
        
    void Uupdate()
    {
        float mfw = Input.GetAxis("Horizontal");
        float mside = Input.GetAxis("Vertical");

        Rigidbody body = GetComponent<Rigidbody>();
body.AddTorque(new Vector3(mfw, 0, mside) * speed * Time.deltaTime); 
    }
}