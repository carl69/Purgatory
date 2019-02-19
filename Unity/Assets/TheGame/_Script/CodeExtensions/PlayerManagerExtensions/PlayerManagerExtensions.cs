using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerExtensions : MonoBehaviour
{
    private PlayerManager playerManager_;

    [SerializeField]
    private Animator animator_;

    private int comboNumber = -1;


    private void Start()
    {
        playerManager_ = GetComponent<PlayerManager>();
    }

    public void executeComboSet1()
    {
        AttackData comboAttackk = playerManager_.ComboSet1.Dequeue();
        Debug.Log(comboAttackk.Tag);
        animator_.SetTrigger(comboAttackk.AttackAnimation);
        playerManager_.ComboSet1.Enqueue(comboAttackk);
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
