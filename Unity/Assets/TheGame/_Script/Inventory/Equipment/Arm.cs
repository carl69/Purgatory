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

    // Struct with the stats
    [SerializeField]
    private ArmStats armStats;
    public ArmStats ArmtStats_ { get { return this.armStats; } }
}
