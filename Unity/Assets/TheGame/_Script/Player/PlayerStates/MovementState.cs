using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{

    public float moveSpeed = 5;
    public float gravityScale = 100;

    /// <summary>
    private char inputController = 'K';
    /// </summary>

    public CharacterController controller;
    InputManager controllerManager;
    public Vector3 movementDirection;


    string verticalInput;
    string horizontalInput;

    public MovementState(Player player) : base(player)
    {

    }

    public override void OnStateEnter()//MoementStatement start
    {
        controller = player.GetComponent<CharacterController>();
        controllerManager = player.GetComponent<InputManager>();

    }

    public override void Tick()//MovementStatement update
    {
        //horizontal plane movement (3D)
        movementDirection = (player.transform.forward * Input.GetAxis(controllerManager.controllerVerticalInput) * moveSpeed) 
            + (player.transform.right * Input.GetAxis(controllerManager.controllerHorizontalInput) * moveSpeed);
        //vertical movement(3D) 
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

        //////////if (Input.GetButtonDown("Atack_P" + player.Player_Id))
        //////////{
        //////////    player.SetState(new AtackState(player));
        //////////}

        //////////Vector3 dahsDirection;
        //////////if (Input.GetButtonDown("Dash_P" + player.Player_Id + inputController))//when the dash button is pressed we make the calculations of movement direction and use this information that it is going to be used for the DashState
        //////////{


        //////////    if (Input.GetAxis("Vertical_P" + player.Player_Id + inputController) == 0 && Input.GetAxis("Horizontal_P" + player.Player_Id + inputController) == 0)
        //////////    {//if the player is not movig the dash is backwards
        //////////        dahsDirection =  -player.transform.forward;
        //////////        player.SetState(new DashState(player, dahsDirection));
        //////////    }
        //////////    else
        //////////    {//if not we calculate the dash direction on the direction of the player movement
        //////////        Vector3 forwardMovement = player.transform.forward * Input.GetAxis("Vertical_P" + player.Player_Id + inputController);
        //////////        Vector3 sideMovement = player.transform.right * Input.GetAxis("Horizontal_P" + player.Player_Id + inputController);
        //////////        dahsDirection = sideMovement + forwardMovement;

        //////////        player.SetState(new DashState(player, dahsDirection));
        //////////    }
        //////////}

        if (Input.GetKeyDown(KeyCode.N))
            player.SetState(new AttackState(player));

        controller.Move(movementDirection * Time.deltaTime);
    }


}
