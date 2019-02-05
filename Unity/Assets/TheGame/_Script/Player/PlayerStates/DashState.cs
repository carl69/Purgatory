using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : State
{

    Vector3 newPosition;
    Vector3 dashDirection_;
    float dashDistance_ = 3;
    public float smoothLevel = 5;

    public DashState(Player player, Vector3 dashDirection) : base(player){
        dashDirection_ = dashDirection;
    }



    public override void Tick()
    {
        player.transform.position = Vector3.Lerp(player.transform.position, newPosition, Time.deltaTime * smoothLevel);
        if (player.transform.position.x > newPosition.x - 0.2 && player.transform.position.x < newPosition.x + 0.2 && player.transform.position.z > newPosition.z - 0.2 && player.transform.position.z < newPosition.z + 0.2)
        {
            // will return the state to movement state
            player.SetState(new MovementState(player));
        }
    }

    public override void OnStateEnter()
    {
        newPosition = player.transform.position;
        newPosition = player.transform.position + dashDirection_.normalized * dashDistance_;
        //player.SetState(new MovementState(player));
    }
}
