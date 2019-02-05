using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DashState : State
{
    public DashState(Player player) : base(player) { }

    public override void Tick()
    {

    }

    public override void OnStateEnter()
    {
        Debug.Log("Dash");
        player.SetState(new MovementState(player));
    }
}
