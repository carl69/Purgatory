using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Chest : EquipmentItems
{
    public Chest(string t, int id) : base(t, id)
    {
    }

    // New variables for the chest
    [SerializeField]
    private float resistance;
}
