using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerExtensions : MonoBehaviour
{
    private PlayerManager playerManager_;
    Animator animator_;

    private void Start()
    {
        playerManager_ = GetComponent<PlayerManager>();
    }

    public void executeComboSet1()
    {
        string combo = playerManager_.ComboSet1.Dequeue();

        animator_ = getAnimator();
        animator_.SetTrigger(combo);

        playerManager_.ComboSet1.Enqueue(combo);
    }

    private Animator getAnimator()
    {
        Animator animator = playerManager_.Player.GetComponentInChildren<Animator>();
        return animator;
    }
}
