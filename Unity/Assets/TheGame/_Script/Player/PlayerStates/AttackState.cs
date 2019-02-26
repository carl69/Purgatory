using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackState : State
{
    // Time allowed to press the next button
    [SerializeField] 
    private float AllowedTimeBetweenButtons = 2.0f;

    // variable to store te time when the button was pressed
    private float timeLastButtonPressed;


    WeaponDealDamage weaponDealDamage_;
    // Change the constructor to have a combo inserted
    public AttackState(Player player) : base(player)
    {

    }


    public override void Tick()
    {
        //if(!weaponDealDamage_.isAtacking())
        //    player.SetState(new MovementState(player));

        // if the player can continue the combo, we give him the opportunity, if not, he returns to movement state
        if (CanContinueCombo())
        {
            if (Input.GetKeyDown(KeyCode.N))
                performAttack();
        }
        else
            player.SetState(new MovementState(player));
        
    }

    // Boolean method to check if the player can continue with the combo
    private bool CanContinueCombo()
    {
        if (Time.time - timeLastButtonPressed < AllowedTimeBetweenButtons)
            return true;
        else
            return false;
    }

    // Method that throws the attack of the respective combo
    private void performAttack()
    {
        player.PlayerManager.ComboSystem.executeComboSet(player.PlayerManager.ComboSet1);
        timeLastButtonPressed = Time.time;
    }

    public override void OnStateEnter()
    {
        //weaponDealDamage_ = player.GetComponentInChildren<WeaponDealDamage>();
        //player.transform.GetChild(0).GetComponent<Animator>().SetTrigger("Attack");


        //weaponDealDamage_.Attack();

        // We execute the first combo odf the queue
        performAttack();
    }

    public override void OnStateExit()
    {
        // When we exit from this state, we reset the combos
        player.PlayerManager.ComboSystem.restartCombo(player.PlayerManager.ComboSet1);
    }

}
