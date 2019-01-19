using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour {
    float placeholderMovementSpeed = 10;
    float placeholderRotateDampening = 10;

    public Transform placeholderTarget;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        // very basic looking

        var lookPos = placeholderTarget.position - transform.position;
        lookPos.y = 0;
        var rotation = Quaternion.LookRotation(lookPos);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * placeholderRotateDampening);

        // very basic walking
        
        Vector3 RIGHT = transform.TransformDirection(Vector3.right);
        Vector3 FORWARD = transform.TransformDirection(Vector3.forward);
        transform.localPosition += RIGHT * Input.GetAxis("Horizontal") * placeholderMovementSpeed * Time.deltaTime;
        transform.localPosition += FORWARD * Input.GetAxis("Vertical") * placeholderMovementSpeed * Time.deltaTime;
    }
}
