using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    [SerializeField]
    private float stamina;
    public float Stamina { get { return this.stamina; } }

    // List with the specific gear of the player
    private List<InventoryItems> gear;
}
