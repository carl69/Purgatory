using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController controller;
    public float gravityScale;
    // Start is called before the first frame update

    public Vector3 movementDirection;

    public Vector3 Drag;
    public float DashDistance;

    Rigidbody rb;
    public float smoothLevel;

    Transform newPositionTransform;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
        newPositionTransform = transform;
    }

    // Update is called once per frame
    void Update()
    {

        //movementDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, 0.0f, Input.GetAxis("Vertical")*moveSpeed);

        //TRY TO USE TWO DIFFRENT VARIABLES IN ORDER TO KEEP THAT INFORMATION AND CAN USE IT TO THE DODGE HABILITY
        movementDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal")* moveSpeed);

        movementDirection.y = movementDirection.y + gravityScale*(Physics.gravity.y * Time.deltaTime);

        // GONNA PUT PLACEHOLDER CODE HERE
        if (movementDirection.x != 0 || movementDirection.z != 0)
        {
            transform.GetChild(0).GetComponent<Animator>().SetBool("Walking",true);
            transform.GetChild(0).GetComponent<Animator>().SetFloat("WalkingSpeed", movementDirection.z);

        }
        else
        {

            transform.GetChild(0).GetComponent<Animator>().SetBool("Walking", false);

        }

        if (Input.GetButtonDown("Fire1"))
        {
            transform.GetChild(0).GetComponent<Animator>().SetTrigger("Attack");

        }

       

        if (Input.GetButtonDown("Dash"))
        {
            newPositionTransform.position = transform.position + transform.forward * DashDistance;
        }


        ////////////////////////////////////////////////////////////////////////////////////////
        controller.Move(movementDirection * Time.deltaTime);
           
    }


    private void LateUpdate()
    {

        //transform.position = Vector3.Lerp(
        //   transform.position, newPositionTransform.position, Time.deltaTime * smoothLevel);
    }
}
