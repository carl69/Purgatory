using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerExtensions : MonoBehaviour
{
    private PlayerManager playerManager_;

    [SerializeField]
    private Animator animator_;

    private int comboNumber = -1;
    private float timeLastAttackExecuted;


    private void Start()
    {
        playerManager_ = GetComponent<PlayerManager>();
    }

    public void executeComboSet(Queue<AttackData> comboSet)
    {


        if (Time.time > timeLastAttackExecuted + playerManager_.AllowedTimeBetweenAttacks)
        {
            AttackData comboAttack = comboSet.Dequeue();
            animator_.SetTrigger(comboAttack.AttackAnimation);
            comboSet.Enqueue(comboAttack);

            timeLastAttackExecuted = Time.time;
        }
        else
        {
            Debug.Log("Failed Combo");
        }
        
    }

    public void addAttackToCombo(Queue<AttackData> comboSet, AttackData attack)
    {
        comboSet.Enqueue(attack);
        comboNumber++;
        attack.ComboNumber = comboNumber;
    }

    public void removeAttackFromCombo(Queue<AttackData> comboSet, AttackData attack)
    {
        comboSet.Dequeue();
        comboNumber--;
    }
}
