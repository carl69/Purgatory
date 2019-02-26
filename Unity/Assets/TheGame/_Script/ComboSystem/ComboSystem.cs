using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComboSystem : MonoBehaviour
{
    private PlayerManager playerManager_;

    [SerializeField]
    private Animator animator_;

    private int comboNumber = -1;


    private void Start()
    {
        playerManager_ = GetComponent<PlayerManager>();
    }

    public void addAttackToCombo(Queue<Weapon_Attack> comboSet, Weapon_Attack attack)
    {
        comboSet.Enqueue(attack);
        comboNumber++;
        attack.ComboNumber = comboNumber;
    }

    public void removeAttackFromCombo(Queue<Weapon_Attack> comboSet)
    {
        comboSet.Dequeue();
        comboNumber--;
    }

    public void executeComboSet(Queue<Weapon_Attack> comboSet)
    {
        Weapon_Attack comboAttack = comboSet.Dequeue();
        animator_.SetTrigger(comboAttack.AttackAnimation);
        comboSet.Enqueue(comboAttack);

        Debug.Log(comboAttack.Tag + " executed");
    }

    public void restartCombo(Queue<Weapon_Attack> comboSet)
    {
        while (comboSet.Peek().ComboNumber != 0)
        {
            Weapon_Attack attack = comboSet.Dequeue();
            comboSet.Enqueue(attack);
        }
    }

}
