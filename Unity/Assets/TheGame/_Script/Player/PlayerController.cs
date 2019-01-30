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

    public float X;
    public float Y;

    public Vector3 Drag;
    public float DashDistance;

    public float smoothLevel;

    Vector3 newPosition;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        newPosition = transform.position;
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
            if (movementDirection.x == 0 && movementDirection.z == 0)
            {//needs to be refinde to be activate only when the player is not pressing, the movement takes a little long than the pressing
                newPosition = transform.position + transform.forward * DashDistance;
                this.transform.position = newPosition;
            }
            else
            {
                Vector3 forwardMovement = transform.forward * Input.GetAxis("Vertical");
                Vector3 sideMovement = transform.right * Input.GetAxis("Horizontal");
                Vector3 dahsDirection = sideMovement + forwardMovement;
                transform.position += dahsDirection.normalized * DashDistance;
            
            }
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
