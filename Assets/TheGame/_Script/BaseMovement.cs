using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMovement : MonoBehaviour {
    float placeholderMovementSpeed = 5;
    float placeholderRotateDampening = 20;

    public Transform placeholderTarget;

    public enum PlayerState
    {
        Walking,Action,Block,dodge
    }
    public PlayerState currentPlayerState;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        switch (currentPlayerState)
        {
            case PlayerState.Walking:
                // very basic looking

                var lookPos = placeholderTarget.position - transform.position;
                lookPos.y = 0;
                var rotation = Quaternion.LookRotation(lookPos);
                transform.rotation = Quaternion.Slerp(transform.rotation, rotation, Time.deltaTime * placeholderRotateDampening);

                // very basic walking

                Vector3 RIGHT = transform.TransformDirection(Vector3.right);
                Vector3 FORWARD = transform.TransformDirection(Vector3.forward);
                transform.localPosition += RIGHT * Input.GetAxis("Horizontal") * placeholderMovementSpeed / 1.5f * Time.deltaTime; // makes the player move slower to the sides
                transform.localPosition += FORWARD * Input.GetAxis("Vertical") * placeholderMovementSpeed * Time.deltaTime;

                break;
            case PlayerState.Action:

                // Sett animation for the action

                // trigger or enchantment

                // Do the action

                break;

            case PlayerState.Block:
                break;

            case PlayerState.dodge:
                break;

            default:
                break;
        }
    }
}
