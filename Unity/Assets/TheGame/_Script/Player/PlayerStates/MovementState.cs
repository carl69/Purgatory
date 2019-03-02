using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementState : State
{

    public float playerMovementState = 5;
    float gravityScale = 100;

    /// <summary>
    //private char inputController = 'K';
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
        movementDirection = (player.transform.forward * Input.GetAxis(controllerManager.controllerVerticalInput) * playerMovementState) 
            + (player.transform.right * Input.GetAxis(controllerManager.controllerHorizontalInput) * playerMovementState);
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


        if (player.TestingWithKeyBoard || player.TestingWithPs4Controller || player.TestingWithXboxController)
        {
            //dashing
            dash_testing();
            //attacking
            attack_1_testing();

        }
        else
        {
            //dashing
            dash_game();
            //attacking
            attack_1_game();
        }

        //if (Input.GetKeyDown(KeyCode.N))
        //    player.SetState(new AttackState(player, player.PlayerManager.ComboSet1));

        controller.Move(movementDirection * Time.deltaTime);
    }




    void dash_testing()
    {
        if (Input.GetButtonDown(player.InputManager.DashInput))
        {
            if (Input.GetAxis(controllerManager.controllerVerticalInput) == 0 && Input.GetAxis(controllerManager.controllerHorizontalInput) == 0)
            {//if the player is not movig the dash is backwards
                backwardsDash();
            }
            else
            {//if not we calculate the dash direction on the direction of the player movement
                directionalDash();
            }
        }
    }

    void dash_game()
    {
        if (hInput.GetButtonDown(player.InputManager.DashInput))
        {
            if (Input.GetAxis(controllerManager.controllerVerticalInput) == 0 && Input.GetAxis(controllerManager.controllerHorizontalInput) == 0)
            {//if the player is not movig the dash is backwards
                backwardsDash();

            }
            else
            {//if not we calculate the dash direction on the direction of the player movement
                directionalDash();
            }
        }
    }

    void backwardsDash()
    {
        Vector3 dahsDirection;
        dahsDirection = -player.transform.forward;
        player.SetState(new DashState(player, dahsDirection));
    }

    void directionalDash()
    {
        Vector3 dahsDirection;
        Vector3 forwardMovement = player.transform.forward * Input.GetAxis(controllerManager.controllerVerticalInput);
        Vector3 sideMovement = player.transform.right * Input.GetAxis(controllerManager.controllerHorizontalInput);
        dahsDirection = sideMovement + forwardMovement;

        player.SetState(new DashState(player, dahsDirection));
    }

    void attack_1_testing()
    {
        if (Input.GetButtonDown(player.InputManager.AttackInput1))
        {
            player.SetState(new AttackState(player, player.PlayerManager.ComboSet1, player.PlayerManager.ComboSet2, 
                player.InputManager.AttackInput1));
        }
    }

    void attack_2_testing()
    {
        //if (Input.GetButtonDown(player.InputManager.AttackInput1))
        //{
        //    player.SetState(new AttackState(player, player.PlayerManager.ComboSet1));
        //}
    }

    void attack_1_game()
    {
        if (hInput.GetButtonDown(player.InputManager.AttackInput1))
        {
            player.SetState(new AttackState(player, player.PlayerManager.ComboSet1, player.PlayerManager.ComboSet2, 
                player.InputManager.AttackInput1));
        }
    }

}
