using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AtackState : State
{
    [SerializeField] 
    private float AllowedTimeBetweenButtons = 2.0f;

    private float timeLastButtonPressed;

    int index;

    WeaponDealDamage weaponDealDamage_;
    public AtackState(Player player) : base(player)
    {

    }

    // Start is called before the first frame update
    public override void Tick()// this work as the Update()
    {
        //if(!weaponDealDamage_.isAtacking())
        //    player.SetState(new MovementState(player));

        if (Time.time - timeLastButtonPressed < AllowedTimeBetweenButtons)
        {
            if (Input.GetKeyDown(KeyCode.N))
            {
                player.PlayerManager.PlayerManagerExtensions.executeComboSet(player.PlayerManager.ComboSet1);
                timeLastButtonPressed = Time.time;
            }
        }
        else
        {
            Debug.Log("Change to mov state");
            player.SetState(new MovementState(player));
        }
    }

    public override void OnStateEnter()//MoementStatement start
    {
        //weaponDealDamage_ = player.GetComponentInChildren<WeaponDealDamage>();
        //player.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Attack");


        //weaponDealDamage_.Attack();

        player.PlayerManager.PlayerManagerExtensions.executeComboSet(player.PlayerManager.ComboSet1);
        timeLastButtonPressed = Time.time;
    }

    public override void OnStateExit()
    {
        player.PlayerManager.PlayerManagerExtensions.restartCombo(player.PlayerManager.ComboSet1);
    }

}
