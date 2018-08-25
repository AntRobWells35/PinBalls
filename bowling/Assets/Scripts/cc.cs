using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cc : MonoBehaviour {
    public Transform playertransform; 
    public bool AroundPlayer;
    public float Rotspeed = 5.0f; 
	private Vector3 _cameraOffset;
    [Range(0.0f, 1.0f)]
    public float SmoothFact = 0.5f;
    public bool LookAtPlayer = false; 

	// Use this for initialization
	void Start () {
        _cameraOffset = transform.position - playertransform.position;  
	}
	
	// Update is called once per frame
	void LateUpdate () {
        if (AroundPlayer)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Horizontal") * Rotspeed, Vector3.up);
            _cameraOffset = camTurnAngle * _cameraOffset; 
        }
        Vector3 newPos = playertransform.position + _cameraOffset; 

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFact);
        if (LookAtPlayer || AroundPlayer)
            transform.LookAt(playertransform); 

    }
}
