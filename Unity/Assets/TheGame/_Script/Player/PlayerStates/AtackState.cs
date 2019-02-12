using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackState : State
{

    WeaponDealDamage weaponDealDamage_;
    public AtackState(Player player) : base(player)
    {

    }
    // Start is called before the first frame update
    public override void Tick()// this work as the Update()
    {
        if(!weaponDealDamage_.isAtacking())
            player.SetState(new MovementState(player));
    }

    public override void OnStateEnter()//MoementStatement start
    {
        weaponDealDamage_ = player.GetComponentInChildren<WeaponDealDamage>();
        player.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Attack");


        weaponDealDamage_.Attack();

    }

}
