using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {

    public float speed;
    private Rigidbody rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Fixedupdate()
    {
        float mfw = Input.GetAxis("Horizontal");
        float mside = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(mfw, 0.0F, mside);
        rb.AddForce(movement * speed); 
    }
}