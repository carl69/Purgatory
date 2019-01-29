using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Leg : EquipmentItems
{
    public Leg(string t, int id) : base(t, id)
    {
    }

    // New variables for the leg
    [SerializeField]
    private float resistance;
}
