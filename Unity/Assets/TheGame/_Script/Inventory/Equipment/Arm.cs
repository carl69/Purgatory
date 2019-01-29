using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Arm : EquipmentItems
{
    public Arm(string t, int id) : base(t, id)
    {
    }

    // New variables for the arm
    [SerializeField]
    private float endurance;
}
