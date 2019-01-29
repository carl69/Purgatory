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

    Vector3 _velocity;
    Vector3 Drag;
    float DashDistance;

    Rigidbody rb;

    public float dashTime;
    public float dashSpeed;
    public float startDashTime;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();


        dashTime = startDashTime;
    }

    // Update is called once per frame
    void Update()
    {

        //movementDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, 0.0f, Input.GetAxis("Vertical")*moveSpeed);
        movementDirection = (transform.forward * Input.GetAxis("Vertical") /** moveSpeed*/) + (transform.right * Input.GetAxis("Horizontal")/** moveSpeed*/);

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

        if (Input.GetButtonDown("Dash"))
        {
            dash();
        }

        controller.Move(movementDirection * moveSpeed * Time.deltaTime);


    }

    void dash()
    {
            Debug.Log("Dash");
        movementDirection += Vector3.Scale(transform.forward,
                                       DashDistance * new Vector3((Mathf.Log(1f / (Time.deltaTime * Drag.x + 1)) / -Time.deltaTime),
                                                                  0,
                                                                  (Mathf.Log(1f / (Time.deltaTime * Drag.z + 1)) / -Time.deltaTime)));

        movementDirection.x /= 1 + Drag.x * Time.deltaTime;
        movementDirection.y /= 1 + Drag.y * Time.deltaTime;
        ////movementDirection.z /= 1 + Drag.z * Time.deltaTime;

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
