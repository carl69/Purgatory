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
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        //movementDirection = new Vector3(Input.GetAxis("Horizontal")*moveSpeed, 0.0f, Input.GetAxis("Vertical")*moveSpeed);
        movementDirection = (transform.forward * Input.GetAxis("Vertical") * moveSpeed) + (transform.right * Input.GetAxis("Horizontal")* moveSpeed);

        movementDirection.y = movementDirection.y + gravityScale*(Physics.gravity.y * Time.deltaTime);

        controller.Move(movementDirection * Time.deltaTime);

 

    }
}
