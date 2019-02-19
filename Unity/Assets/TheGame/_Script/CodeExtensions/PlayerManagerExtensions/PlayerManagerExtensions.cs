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
        string combo = playerManager_.ComboSet1.Dequeue();
        animator_.SetTrigger(combo);
        playerManager_.ComboSet1.Enqueue(combo);
    }

    public void addAttackToCombo(Queue<string> comboSet, AttackData attack)
    {
        comboSet.Enqueue(attack.AttackAnimation);
        comboNumber++;
        attack.ComboNumber = comboNumber;
    }

    public void removeAttackFromCombo(Queue<string> comboSet, AttackData attack)
    {
        comboSet.Dequeue();
        comboNumber--;
    }
}
