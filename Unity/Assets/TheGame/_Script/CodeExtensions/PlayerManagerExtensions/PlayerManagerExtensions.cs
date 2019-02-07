using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManagerExtensions : MonoBehaviour
{
    private PlayerManager playerManager_;

    private void Start()
    {
        playerManager_ = GetComponent<PlayerManager>();
    }

    public void executeComboSet1()
    {
        InventoryItems combo = playerManager_.ComboSet1.Dequeue();
        playerManager_.ComboSet1.Enqueue(combo);
    }
}
