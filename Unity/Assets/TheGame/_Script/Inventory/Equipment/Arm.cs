using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Arm : EquipmentItems
{
    // Constructor of the class
    public Arm(string t, int Id) : base(t, Id)
    {
    }

    // New variables for the arm
    [SerializeField]
    private float endurance;
    public float Endurance
    {
        get { return this.endurance; }
        set { this.endurance = value; }
    }
}
