using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private float stamina;
    public float Stamina { get { return this.stamina; } }

    // Two queues with the combos the player can perform
    private Queue<InventoryItems> ComboSet1;
    private Queue<InventoryItems> ComboSet2;
}
