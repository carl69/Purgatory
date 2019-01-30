using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Leg : EquipmentItems
{
    // Constructor of the class
    public Leg(string t, int Id) : base(t, Id)
    {
    }

    // New attributes for the leg
    [SerializeField]
    private float endurance;
    public float Endurance
    {
        get { return this.endurance; }
        set { this.endurance = value; }
    }
}
