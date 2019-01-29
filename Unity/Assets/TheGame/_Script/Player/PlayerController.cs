using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed;
    public CharacterController controller;
    public float gravityScale;
    // Start is called before the first frame update

    private Vector3 movementDirection;

    public Vector3 Drag;
    public float DashDistance;

    Rigidbody rb;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

        //movementDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, 0.0f, Input.GetAxis("Vertical")*moveSpeed);
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

        ////////////////////////////////////////////////////////////////////////////////////////

        if (Input.GetButtonDown("Dash"))
        {
            dash();
        }

        controller.Move(movementDirection * Time.deltaTime);


    }

    void dash()
    {
        if (movementDirection.x != 0.0f || movementDirection.z != 0.0f)
            movementDirection += new Vector3(movementDirection.x / Mathf.Abs(movementDirection.x), 0.0f, movementDirection.z / Mathf.Abs(movementDirection.z)) * DashDistance;
        //else
        //    controller.Move(transform.forward * moveSpeed * Time.deltaTime);

    }
    //IEnumerator dash()
    //{
    //    for (float f = dashTime; f >= 0; f -= Time.deltaTime)
    //    {
    //        controller.Move(movementDirection * 20 * Time.deltaTime);
    //        yield return null;
    //    }
    //}
}
