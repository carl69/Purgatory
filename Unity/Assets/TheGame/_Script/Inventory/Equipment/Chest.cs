using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Chest : EquipmentItems
{
    // Constructor of the class
    public Chest(string t, int Id) : base(t, Id)
    {
    }

    // New attributes for the chest
    [SerializeField]
    private float resistance;
    public float Resistance
    {
        get { return this.resistance; }
        set { this.resistance = value; }
    }
}
