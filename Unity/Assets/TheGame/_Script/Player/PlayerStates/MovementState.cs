using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{

    public float moveSpeed;
    public CharacterController controller;
    public float gravityScale;
    // Start is called before the first frame update

    public Vector3 movementDirection;

    public float X;
    public float Y;

    public Vector3 Drag;
    public float DashDistance;
    public bool dashing = false;

    public float smoothLevel;

    Vector3 newPosition;

    public MovementState(Player player) : base(player)
    {

    }

    public override void Tick()//MovementStatement update
    {
        movementDirection = (player.transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (player.transform.right * Input.GetAxis("Horizontal") * moveSpeed);

        movementDirection.y = movementDirection.y + gravityScale * (Physics.gravity.y * Time.deltaTime);

        // GONNA PUT PLACEHOLDER CODE HERE
        if (movementDirection.x != 0 || movementDirection.z != 0)
        {
            player.transform.GetChild(0).GetComponent<Animator>().SetBool("Walking", true);
            player.transform.GetChild(0).GetComponent<Animator>().SetFloat("WalkingSpeed", movementDirection.z);

        }
        else
        {

            player.transform.GetChild(0).GetComponent<Animator>().SetBool("Walking", false);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            player.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Attack");

        }

    }

    public override void OnStateEnter()//MoementStatement start
    {
        controller = player.GetComponent<CharacterController>();
        newPosition = player.transform.position;
    }
}
