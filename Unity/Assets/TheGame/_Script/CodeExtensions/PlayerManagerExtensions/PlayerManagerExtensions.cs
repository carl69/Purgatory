using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerExtensions : MonoBehaviour
{
    private PlayerManager playerManager_;

    [SerializeField]
    private Animator animator_;


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
}
