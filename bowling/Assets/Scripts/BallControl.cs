using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallControl : MonoBehaviour {
    public float speed = 10.0F; 
     	private Rigidbody Rb;
    public float rotationSpeed = 75.0f;

    void Start()
    {
        Rb = GetComponent<Rigidbody>();
        Cursor.lockState = CursorLockMode.Locked; 
    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Mouse Y") * speed;


        float rotation = Input.GetAxis("Mouse X") * rotationSpeed;

        rotation *= Time.deltaTime;

        Vector3 movement = new Vector3(rotation, 0.0F, translation);
        Rb.AddForce(movement * speed);

        transform.Rotate(0, rotation, 0);
        if (Input.GetKeyDown("escaps"))
            Cursor.lockState = CursorLockMode.None;

    }
  
    }
